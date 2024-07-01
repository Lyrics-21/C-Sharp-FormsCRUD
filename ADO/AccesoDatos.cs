using System.Data;
using Libreria_De_Clases;
using Microsoft.Data.SqlClient;

namespace ADO
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand? comando;
        private SqlDataReader? lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.conexionPersonajes;
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        public List<Personaje> MostrarListaDatos()
        {
            List<Personaje> lista = new List<Personaje>();  
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT id, nombre, vida, nivel, estilo, daño, tipoArco, cantidadFlechas, tipoMagia, mana, tipoArmadura, fuerza  FROM Tabla_Personajes";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string estilo = lector["estilo"].ToString();

                    switch(estilo)
                    {
                        case "Arquero/a":
                            Arquero arquero = new Arquero();
                            arquero.Nombre = lector[1].ToString();
                            arquero.Vida = (int)lector[2];
                            arquero.Nivel = (int)lector[3];
                            arquero.Estilo = lector[4].ToString();
                            arquero.Daño = (int)lector[5];
                            arquero.TipoArco = (TipoArco)lector[6];
                            arquero.CantidadFlechas = (int)lector[7];
                            lista.Add(arquero);
                            break;

                        case "Mago":
                            Mago mago = new Mago();
                            mago.Nombre = lector[1].ToString();
                            mago.Vida = (int)lector[2];
                            mago.Nivel = (int)lector[3];
                            mago.Estilo = lector[4].ToString();
                            mago.Daño = (int)lector[5];
                            mago.TipoMagia = (TipoMagia)lector[8];
                            mago.Mana = (int)lector[9];
                            lista.Add(mago);
                            break;

                        case "Tanque":
                            Tanque tanque = new Tanque();
                            tanque.Nombre = lector[1].ToString();
                            tanque.Vida = (int)lector[2];
                            tanque.Nivel = (int)lector[3];
                            tanque.Estilo = lector[4].ToString();
                            tanque.Daño = (int)lector[5];
                            tanque.TipoArmadura = (TipoArmadura)lector[10];
                            tanque.Fuerza = (int)lector[11];
                            lista.Add(tanque);
                            break;
                    }
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }

        #endregion

        #region Insert

        public bool AgregarDato(Coleccion coleccion)
        {
            bool rta = true;

            try
            {
                foreach (Personaje personaje in coleccion.listPersonajes)
                {
                    this.comando = new SqlCommand();

                    this.comando.Parameters.AddWithValue("@nombre", personaje.Nombre);
                    this.comando.Parameters.AddWithValue("@vida", personaje.Vida);
                    this.comando.Parameters.AddWithValue("@nivel", personaje.Nivel);
                    this.comando.Parameters.AddWithValue("@estilo", personaje.Estilo);
                    this.comando.Parameters.AddWithValue("@daño", personaje.Daño);

                    if (personaje is Arquero arquero)
                    {
                        this.comando.Parameters.AddWithValue("@tipoArco", (int)arquero.TipoArco);
                        this.comando.Parameters.AddWithValue("@cantidadFlechas", arquero.CantidadFlechas);
                        this.comando.Parameters.AddWithValue("@tipoMagia", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@mana", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@tipoArmadura", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@fuerza", DBNull.Value);
                    }

                    else if (personaje is Mago mago)
                    {
                        this.comando.Parameters.AddWithValue("@tipoArco", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@cantidadFlechas", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@tipoMagia", (int)mago.TipoMagia);
                        this.comando.Parameters.AddWithValue("@mana", mago.Mana);
                        this.comando.Parameters.AddWithValue("@tipoArmadura", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@fuerza", DBNull.Value);
                    }

                    else if (personaje is Tanque tanque)
                    {
                        this.comando.Parameters.AddWithValue("@tipoArco", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@cantidadFlechas", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@tipoMagia", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@mana", DBNull.Value);
                        this.comando.Parameters.AddWithValue("@tipoArmadura", (int)tanque.TipoArmadura);
                        this.comando.Parameters.AddWithValue("@fuerza", tanque.Fuerza);
                    }

                    string sql = "INSERT INTO Tabla_Personajes (nombre, vida, nivel, estilo, daño, tipoArco, cantidadFlechas, tipoMagia, mana, tipoArmadura, fuerza) VALUES( ";
                    sql += "@nombre, @vida, @nivel, @estilo, @daño, @tipoArco, @cantidadFlechas, @tipoMagia, @mana, @tipoArmadura, @fuerza)";
    
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = sql;
                    this.comando.Connection = this.conexion;

                    this.conexion.Open();

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        rta = false;
                    }
                    else if (this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update

        public bool ModificarDato(Personaje personaje, string nombreAntiguo, string estiloAntiguo)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@nombreAntiguo", nombreAntiguo);
                this.comando.Parameters.AddWithValue("@estiloAntiguo", estiloAntiguo);

                this.comando.Parameters.AddWithValue("@nombre", personaje.Nombre);
                this.comando.Parameters.AddWithValue("@vida", personaje.Vida);
                this.comando.Parameters.AddWithValue("@nivel", personaje.Nivel);
                this.comando.Parameters.AddWithValue("@estilo", personaje.Estilo);
                this.comando.Parameters.AddWithValue("@daño", personaje.Daño);

                if (personaje is Arquero arquero)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", (int)arquero.TipoArco);
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", arquero.CantidadFlechas);
                    this.comando.Parameters.AddWithValue("@tipoMagia", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@mana", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoArmadura", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@fuerza", DBNull.Value);
                }

                else if (personaje is Mago mago)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoMagia", (int)mago.TipoMagia);
                    this.comando.Parameters.AddWithValue("@mana", mago.Mana);
                    this.comando.Parameters.AddWithValue("@tipoArmadura", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@fuerza", DBNull.Value);
                }

                else if (personaje is Tanque tanque)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoMagia", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@mana", DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoArmadura", (int)tanque.TipoArmadura);
                    this.comando.Parameters.AddWithValue("@fuerza", tanque.Fuerza);
                }

                string sql = "UPDATE Tabla_Personajes ";
                sql += "SET nombre = @nombre, vida = @vida, nivel = @nivel, estilo = @estilo, daño = @daño, " +
                    "tipoArco = @tipoArco, cantidadFlechas = @cantidadFlechas, tipoMagia = @tipoMagia, mana = @mana, tipoArmadura = @tipoArmadura, fuerza = @fuerza ";
                sql += "WHERE nombre = @nombreAntiguo AND estilo = @estiloAntiguo";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete

        public bool EliminarDato(string nombre, string estilo, bool opcion)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();


                string sql = "DELETE FROM Tabla_Personajes ";

                if (opcion)
                {
                    this.comando.Parameters.AddWithValue("@nombre", nombre);
                    this.comando.Parameters.AddWithValue("@estilo", estilo);
                    sql += "WHERE nombre = @nombre AND estilo = @estilo";
                }

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}