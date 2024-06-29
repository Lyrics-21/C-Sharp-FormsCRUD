using Libreria_De_Clases;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Forms.FormLogin;
using static System.Windows.Forms.Design.AxImporter;

namespace Forms
{
    public partial class Formulario1 : Form
    {
        #region Atributos

        private string datoNombre; //Este atributo lo utilizo para mostrar el nombre del usuario logeado en el toolstrip
        private string pathPersonajes; //Este atributo guarda el path del archivo json para guardar a los personajes

        private Coleccion coleccion; //Este atributo guarda la collecion de personajes
        private int itemSeleccionado; //Este atributo guarda el item seleccionado de la listbox

        private string pathUsuarios; //Este atributo guarda el path del archivo log de los usuarios logeados
        private string datosUsuarios; //Este atributo guarda los datos de los usuarios logueados

        #endregion

        #region Constructor

        List<object> listaPersonajeParseados = new List<object>();
        public Formulario1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Con esto evito que se pueda cambiar el tamaño del formulario
            this.CenterToScreen(); //Lo centro en pantalla
            this.MaximizeBox = false; //No dejo que se pueda maximizar

            this.coleccion = new Coleccion();
        }

        #endregion

        #region LoadForm
        private void Formulario1_Load(object sender, EventArgs e)
        {
            this.datoNombre = ObtenerDatos.DatoNombre;
            DateTime dateTime = DateTime.Now;
            this.toolStripStatusLabel1.Text = $"{datoNombre} - Logeado - {dateTime.Date.ToString("dd/MM/yyyy")}";

            this.pathUsuarios = Path.Combine(Directory.GetCurrentDirectory(), "Usuarios.log");
            this.datosUsuarios += $"{ObtenerDatos.DatosLogin}Fecha: {dateTime.ToString()}\n";


            //Guarda los datos del usuario en un un archivo .log
            using (StreamWriter sw = new StreamWriter(pathUsuarios, true))
            {
                sw.WriteLine(datosUsuarios);
            }
            try
            {
                //Lee los datos guardados en Usuarios.log y los guarda en un atributo
                using (StreamReader sr = new StreamReader(this.pathUsuarios))
                {
                    this.datosUsuarios = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Deserealizo el archivo Json y lo guardo en la lista dependiendo que tipo de personaje sea
            try
            {
                this.pathPersonajes = Path.Combine(Directory.GetCurrentDirectory(), "personajes.json");

                if (File.Exists(this.pathPersonajes))
                {
                    this.Deserealizar(this.pathPersonajes);
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ocurrio un error al deserializar el archivo\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones

        #region Personajes

        //Verifica si se hizo click en Mago, y si no existe un personaje igual, lo agrega a las listas utilizando sobrecarga +
        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMago formMago = new FormMago();
            this.PersonajeResultCancel(formMago);
            if (formMago.DialogResult == DialogResult.OK)
            {
                if (!EqualsLista(formMago.Magos))
                {
                    this.coleccion += formMago.Magos;

                    this.listBoxPersonajes.Items.Add($"{formMago.Magos.Nombre} - {formMago.Magos.Estilo} - Nivel: {formMago.Magos.Nivel}");
                    formMago.Close();
                }
            }
        }

        //Verifica si se hizo click en Arquero, y si no existe un personaje igual, lo agrega a las listas utilizando sobrecarga +
        private void arqueroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArquera formArquera = new FormArquera();
            this.PersonajeResultCancel(formArquera);
            if (formArquera.DialogResult == DialogResult.OK)
            {
                if (!EqualsLista(formArquera.Arqueros))
                {
                    this.coleccion += formArquera.Arqueros;
                    this.listBoxPersonajes.Items.Add($"{formArquera.Arqueros.Nombre} - {formArquera.Arqueros.Estilo} - Nivel: {formArquera.Arqueros.Nivel}");
                    formArquera.Close();
                }
            }
        }

        //Verifica si se hizo click en Tanque, y si no existe un personaje igual, lo agrega a las listas utilizando sobrecarga +
        private void tanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTanque formTanque = new FormTanque();
            this.PersonajeResultCancel(formTanque);
            if (formTanque.DialogResult == DialogResult.OK)
            {
                if (!EqualsLista(formTanque.Tanques))
                {
                    this.coleccion += formTanque.Tanques;
                    //Agrego un nuevo personaje a la lista
                    this.listBoxPersonajes.Items.Add($"{formTanque.Tanques.Nombre} - {formTanque.Tanques.Estilo} - Nivel: {formTanque.Tanques.Nivel}");
                    formTanque.Close();
                }
            }
        }

        #endregion

        #region Modificar

        //Modifico el personaje sleccionado reutilizando codigo, volviendo a abrir el formulario necesario
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (DevolverMensaje())
            {
                int index = this.listBoxPersonajes.SelectedIndex;
                Personaje personajeAModificar = this.coleccion.listPersonajes[index]; //Guardo el personaje seleccionado

                //Depende que personaje sea le modifico los atributos
                switch (personajeAModificar)
                {
                    case Arquero:
                        FormArquera formArquera = new FormArquera();
                        this.PersonajeResultCancel(formArquera); //Si el DialogResult es Cancel cierra el form
                        if (formArquera.DialogResult == DialogResult.OK && !EqualsLista(formArquera.Arqueros)) //Si el DialogResult es OK muestra el form
                        {
                            this.buttonEliminar.PerformClick(); //Simulo un click para borrar el personaje de la lista
                            this.coleccion += formArquera.Arqueros; //Agrego a la coleccion el nuevo personaje modificado
                            this.listBoxPersonajes.Items.Add($"{formArquera.Arqueros.Nombre} - {formArquera.Arqueros.Estilo}"); //Agrego a la listBox el nuevo personaje modificado
                            formArquera.Close();
                        }
                        break;

                    case Mago:
                        FormMago formMago = new FormMago();
                        this.PersonajeResultCancel(formMago);
                        if (formMago.DialogResult == DialogResult.OK && !EqualsLista(formMago.Magos))
                        {
                            this.buttonEliminar.PerformClick();
                            this.coleccion += formMago.Magos;
                            this.listBoxPersonajes.Items.Add($"{formMago.Magos.Nombre} - {formMago.Magos.Estilo}");
                            formMago.Close();
                        }
                        break;

                    case Tanque:
                        FormTanque formTanque = new FormTanque();
                        this.PersonajeResultCancel(formTanque);
                        if (formTanque.DialogResult == DialogResult.OK && !EqualsLista(formTanque.Tanques))
                        {
                            this.buttonEliminar.PerformClick();
                            this.coleccion += formTanque.Tanques;
                            this.listBoxPersonajes.Items.Add($"{formTanque.Tanques.Nombre} - {formTanque.Tanques.Estilo}");
                            formTanque.Close();
                        }
                        break;
                }
            }
        }

        #endregion

        #region Eliminar
        //Elimina el personaje de la lista dependiendo el index seleccionado utilizando sobrecarga -
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (DevolverMensaje())
            {
                int posicion = this.listBoxPersonajes.SelectedIndex;
                this.listBoxPersonajes.Items.RemoveAt(posicion); // Remuevo de la listbox el personaje seleccionado con el index
                Personaje personajeAEliminar = this.coleccion.listPersonajes[posicion]; //Guardo el personaje seleccionado
                this.coleccion -= personajeAEliminar; //Borro el personaje con sobrecarga -
            }
        }

        #endregion

        #region Mostrar Datos

        //Muestra todos los datos del personaje, llamando al Form MostrarDatos
        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            if (DevolverMensaje()) //Si no seleccione nada o no hay nada en la lista es false
            {
                itemSeleccionado = this.listBoxPersonajes.SelectedIndex;
                MostrarDatos mostrarDatos = new MostrarDatos(this.coleccion.listPersonajes, itemSeleccionado);
                mostrarDatos.Show();
            }
        }

        #endregion

        #region Tools

        //Guardo los personajes en un archivo json
        private void guardarPersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string archivoJson = this.Serializar(this.coleccion.listPersonajes); //Llamo a Serializar para generar un atributo json con la lista serializada
                File.WriteAllText(this.pathPersonajes, archivoJson); //Guardo el atributo anterior en el path
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ocurrio un error al serializar el archivo\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Guardo los datos en el directorio que elija y lo serializo
        private void guardarComoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string archivoJson = this.Serializar(this.coleccion.listPersonajes);
                    File.WriteAllText(saveFileDialog.FileName + ".json", archivoJson); //Lo mismo que en Guardar pero con un path a eleccion
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Abro un archivo desde el openFile y lo deserealizo
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json"; //Filtro el openFile para que solo me muestre archivos Json
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Al momento de abir un nuevo archivo debo resetear todas las listas
                this.coleccion.listPersonajes.Clear();
                this.listBoxPersonajes.Items.Clear();
                try
                {
                    this.Deserealizar(openFileDialog.FileName);

                    //Cambio el path principal para que sea el del archivo sleccionado y no el por defecto en bin
                    this.pathPersonajes = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Muestra todos los usuarios logueados, llamando al Form Usuarios
        private void usuariosLogeadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(this.datosUsuarios);
            usuarios.Show();
        }

        //Ordena los items de forma ascendento o descendente dependiendo el nivel o daño
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OrdenarPersonajes("Nivel", false);
        }

        private void dañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OrdenarPersonajes("Daño", false);
        }

        private void nivelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OrdenarPersonajes("Nivel", true);
        }

        private void dañoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OrdenarPersonajes("Daño", true);
        }

        #endregion

        #endregion

        #region Metodos

        //Genero metodo que si la lista esta vacia o no seleccione nada, me muestre un mensaje
        public bool DevolverMensaje()
        {
            bool estado = false;
            if (this.listBoxPersonajes.Items.Count <= 0)
            {
                MessageBox.Show("Agrege un Personaje", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                estado = false;
            }
            else if (this.listBoxPersonajes.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleccione un personaje", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                estado = false;
            }
            else
            {
                estado = true;
            }
            return estado;
        }

        //Creo un metodo que utiliza el Equals de Personaje o de sus derivados
        public bool EqualsLista(Personaje personaje)
        {
            bool estado = false;
            foreach (Personaje item in this.coleccion.listPersonajes)
            {
                if (item.Equals(personaje))
                {
                    estado = true;
                    MessageBox.Show("Este Personaje ya existe en la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                }
            }
            return estado;
        }

        //Genero un metodo que muestra algun formulario y si presiono Cancelar en el fomrulario, cierra el formulario
        private void PersonajeResultCancel(Form formulario)
        {
            formulario.ShowDialog();
            if (formulario.DialogResult == DialogResult.Cancel)
            {
                formulario.Close();
            }
        }

        //Genero metodo que recorre una lista de personajes y los añade a todos a la listBox del form principal
        public void AñadirPersonajeALista(List<Personaje> listaPersonajes)
        {
            foreach (Personaje personaje in listaPersonajes)
            {
                //Utilizo implicit/explicit
                //string nombre = personaje;
                //int nivel = (int)personaje;
                this.listBoxPersonajes.Items.Add($"{personaje.Nombre} - {personaje.Estilo} - Nivel: {personaje.Nivel}");
            }
        }

        //Genero metodo que ordena de forma ascendente o descendente una lista y la agrega al forms
        public void OrdenarPersonajes(string atributo, bool orden)
        {
            this.listBoxPersonajes.Items.Clear();

            if (atributo == "Nivel")
            {
                if (!orden)
                {
                    //Si el orden es false lo ordena de forma ascendente
                    //CompareTo devuelve 0 si a = b, -1 si a < b y 1 si b > a
                    //Sort si tiene -1 lo ordena de forma ascendente primero a despues b
                    this.coleccion.listPersonajes.Sort((a, b) => a.Nivel.CompareTo(b.Nivel));
                }
                if (orden)
                {
                    //Si el orden es true lo ordena de forma descendente
                    this.coleccion.listPersonajes.Sort((a, b) => b.Nivel.CompareTo(a.Nivel));
                }
            }
            else if (atributo == "Daño")
            {
                if (!orden)
                {
                    this.coleccion.listPersonajes.Sort((a, b) => a.Daño.CompareTo(b.Daño));
                }
                if (orden)
                {
                    this.coleccion.listPersonajes.Sort((a, b) => b.Daño.CompareTo(a.Daño));
                }
            }

            this.AñadirPersonajeALista(this.coleccion.listPersonajes);
        }

        //Serializo una lista y la guardo en otra pero parseada
        public string Serializar(List<Personaje> listaP)
        {
            this.listaPersonajeParseados.Clear();
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            foreach (Personaje personajes in listaP)
            {
                if (personajes is Arquero)
                {
                    this.listaPersonajeParseados.Add((Arquero)personajes);
                }
                else if (personajes is Tanque)
                {
                    this.listaPersonajeParseados.Add((Tanque)personajes);
                }
                else if (personajes is Mago)
                {
                    this.listaPersonajeParseados.Add((Mago)personajes);
                }
            }
            string archivoJson = JsonSerializer.Serialize(this.listaPersonajeParseados, options);

            return archivoJson;
        }

        //Deserealizo un archivo json y lo guardo en una lista
        public void Deserealizar(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string archivoJson = sr.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(archivoJson);

                foreach (JsonElement element in doc.RootElement.EnumerateArray())
                {
                    string tipo = element.GetProperty("Estilo").GetString();
                    switch (tipo)
                    {
                        case "Arquero/a":
                            Arquero arquero = JsonSerializer.Deserialize<Arquero>(element.GetRawText());
                            this.coleccion += arquero;
                            break;

                        case "Mago":
                            Mago mago = JsonSerializer.Deserialize<Mago>(element.GetRawText());
                            this.coleccion += mago;
                            break;

                        case "Tanque":
                            Tanque tanque = JsonSerializer.Deserialize<Tanque>(element.GetRawText());
                            this.coleccion += tanque;
                            break;
                    }
                }
                this.AñadirPersonajeALista(this.coleccion.listPersonajes);
            }
        }

        #endregion

        #region Cerrar
        //Me pregunta si estoy seguro si deseo cerrar el formulario
        private void Formulario1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la Aplicacion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
