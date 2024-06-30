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

        public void MostrarListaDatos(Coleccion coleccion)
        {
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
                    foreach (Personaje personaje in coleccion.listPersonajes)
                    {
                        personaje.Nombre = lector[1].ToString();
                        personaje.Vida = (int)lector[2];
                        personaje.Nivel = (int)lector[3];
                        personaje.Estilo = lector[4].ToString();
                        personaje.Daño = (int)lector[5];

                        if (personaje is Arquero arquero)
                        {
                            arquero.TipoArco = (TipoArco)lector[6];
                            arquero.CantidadFlechas = (int)lector[7];
                        }

                        else if (personaje is Mago mago)
                        {
                            mago.TipoMagia = (TipoMagia)lector[8];
                            mago.Mana = (int)lector[9];
                        }

                        else if (personaje is Tanque tanque)
                        {
                            tanque.TipoArmadura = (TipoArmadura)lector[10];
                            tanque.Fuerza = (int)lector[11];
                        }
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
                    string sql = "INSERT INTO Tabla_Personajes (nombre, vida, nivel, estilo, daño, tipoArco, cantidadFlechas, tipoMagia, mana, tipoArmadura, fuerza) VALUES(";
                    sql += (personaje.Nombre != null ? "'" + personaje.Nombre + "'" : "NULL") + ", ";
                    sql += (personaje.Vida != null ? "'" + personaje.Vida + "'" : "NULL") + ", ";
                    sql += (personaje.Nivel != null ? "'" + personaje.Nivel + "'" : "NULL") + ", ";
                    sql += (personaje.Estilo != null ? "'" + personaje.Estilo + "'" : "NULL") + ", ";
                    sql += (personaje.Daño != null ? "'" + personaje.Daño + "'" : "NULL") + ", ";

                    if (personaje is Arquero arquero)
                    {
                        sql += (arquero.TipoArco != null ? "'" + arquero.TipoArco + "'" : "NULL") + ", ";
                        sql += (arquero.CantidadFlechas != null ? "'" + arquero.CantidadFlechas + "'" : "NULL") + ", ";
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ")");
                    }

                    else if (personaje is Mago mago)
                    {
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += (mago.TipoMagia != null ? "'" + mago.TipoMagia + "'" : "NULL") + ", ";
                        sql += (mago.Mana != null ? "'" + mago.Mana + "'" : "NULL") + ", ";
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ")");
                    }

                    else if (personaje is Tanque tanque)
                    {
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += ("NULL" + ", ");
                        sql += (tanque.TipoArmadura != null ? "'" + tanque.TipoArmadura + "'" : "NULL") + ", ";
                        sql += (tanque.Fuerza != null ? "'" + tanque.Fuerza + "'" : "NULL") + ")";
                    }

                    this.comando = new SqlCommand();

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

        public bool ModificarDato(Personaje personaje)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@nombre", (object)personaje.Nombre ?? DBNull.Value);
                this.comando.Parameters.AddWithValue("@vida", (object)personaje.Vida ?? DBNull.Value);
                this.comando.Parameters.AddWithValue("@nivel", (object)personaje.Nivel ?? DBNull.Value);
                this.comando.Parameters.AddWithValue("@estilo", (object)personaje.Estilo ?? DBNull.Value);
                this.comando.Parameters.AddWithValue("@daño", (object)personaje.Daño ?? DBNull.Value);

                if (personaje is Arquero arquero)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", (object)arquero.TipoArco ?? DBNull.Value);
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", (object)arquero.CantidadFlechas ?? DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoMagia", "NULL");
                    this.comando.Parameters.AddWithValue("@mana", "NULL");
                    this.comando.Parameters.AddWithValue("@tipoArmadura", "NULL");
                    this.comando.Parameters.AddWithValue("@fuerza", "NULL");
                }

                else if (personaje is Mago mago)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", "NULL");
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", "NULL");
                    this.comando.Parameters.AddWithValue("@tipoMagia", (object)mago.TipoMagia ?? DBNull.Value);
                    this.comando.Parameters.AddWithValue("@mana", (object)mago.Mana ?? DBNull.Value);
                    this.comando.Parameters.AddWithValue("@tipoArmadura", "NULL");
                    this.comando.Parameters.AddWithValue("@fuerza", "NULL");
                }

                else if (personaje is Tanque tanque)
                {
                    this.comando.Parameters.AddWithValue("@tipoArco", "NULL");
                    this.comando.Parameters.AddWithValue("@cantidadFlechas", "NULL");
                    this.comando.Parameters.AddWithValue("@tipoMagia", "NULL");
                    this.comando.Parameters.AddWithValue("@mana", "NULL");
                    this.comando.Parameters.AddWithValue("@tipoArmadura", (object)tanque.TipoArmadura ?? DBNull.Value);
                    this.comando.Parameters.AddWithValue("@fuerza", (object)tanque.Fuerza ?? DBNull.Value);
                }

                string sql = "UPDATE Tabla_Personajes ";
                sql += "SET nombre = @nombre, vida = @vida, nivel = @nivel, estilo = @estilo, daño = @daño, " +
                    "tipoArco = @tipoArco, cantidadFlechas = @cantidadFlechas, tipoMagia = @tipoMagia, mana = @mana, tipoArmadura = @tipoArmadura, fuerza = @fuerza ";
                sql += "WHERE nombre = '@nombre'";

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
            catch (Exception)
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

        public bool EliminarDato(string nombre, bool opcion)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();


                string sql = "DELETE FROM Tabla_Personajes ";

                if (opcion)
                {
                    this.comando.Parameters.AddWithValue("@nombre", nombre);
                    sql += "WHERE nombre = @nombre";
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
            catch (Exception)
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