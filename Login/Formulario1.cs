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
        private string datoNombre;
        private string pathPersonajes;

        private Coleccion coleccion;
        private int itemSeleccionado;

        private string pathUsuarios;
        private string datosUsuarios;

        List<object> listaPersonajeParseados = new List<object>();
        public Formulario1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;

            this.coleccion = new Coleccion();
        }
        private void Formulario1_Load(object sender, EventArgs e)
        {
            datoNombre = ObtenerDatos.DatoNombre;
            DateTime dateTime = DateTime.Now;
            this.toolStripStatusLabel1.Text = $"{datoNombre} - Logeado - {dateTime.Date.ToString("dd/MM/yyyy")}";

            this.pathUsuarios = Path.Combine(Directory.GetCurrentDirectory(), "Usuarios.log");
            this.datosUsuarios += $"{ObtenerDatos.DatosLogin}Fecha: { dateTime.ToString()}\n";

            if (File.Exists(this.pathPersonajes))
            {
                // Guardar el mensaje en el archivo .log
                using (StreamWriter sw = new StreamWriter(pathUsuarios, true))
                {
                    sw.WriteLine(datosUsuarios);
                }

                using (StreamReader sr = new StreamReader(this.pathUsuarios))
                {
                    this.datosUsuarios = sr.ReadToEnd(); 
                }
            }

            try
            {
                this.pathPersonajes = Path.Combine(Directory.GetCurrentDirectory(), "personajes.json");

                if (File.Exists(this.pathPersonajes))
                {
                    using (StreamReader sr = new StreamReader(this.pathPersonajes))
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
                        foreach (Personaje personaje in this.coleccion.listPersonajes)
                        {
                            this.listBoxPersonajes.Items.Add($"{personaje.Nombre} - {personaje.Estilo} - Nivel: {personaje.Nivel}");
                        }
                    }
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

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Creo un metodo que utiliza el Equals de Personaje o de sus derivados
        public bool equalsLista(Personaje personaje)
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

        //Verifica si se hizo click en Mago, y si no existe un personaje igual, lo agrega a las listas utilizando sobrecarga +
        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMago formMago = new FormMago();
            this.PersonajeResultCancel(formMago);
            if (formMago.DialogResult == DialogResult.OK)
            {
                if (!equalsLista(formMago.Magos))
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
                if (!equalsLista(formArquera.Arqueros))
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
                if (!equalsLista(formTanque.Tanques))
                {
                    this.coleccion += formTanque.Tanques;
                    this.listBoxPersonajes.Items.Add($"{formTanque.Tanques.Nombre} - {formTanque.Tanques.Estilo} - Nivel: {formTanque.Tanques.Nivel}");
                    formTanque.Close();
                }
            }
        }

        //Si le da a boton Guardar, agrega los personajes a un nueva lista pero Parseados, para que al momento de serealizar, se serializen con sus respectivos atributos
        private void guardarPersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true,
                };
                foreach (Personaje personajes in this.coleccion.listPersonajes)
                {
                    if (personajes is Arquero)
                    {
                        listaPersonajeParseados.Add((Arquero)personajes);
                    }
                    else if (personajes is Tanque)
                    {
                        listaPersonajeParseados.Add((Tanque)personajes);
                    }
                    else if (personajes is Mago)
                    {
                        listaPersonajeParseados.Add((Mago)personajes);
                    }
                }
                string archivoJson = JsonSerializer.Serialize(listaPersonajeParseados, options);
                File.WriteAllText(this.pathPersonajes, archivoJson);
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

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Modifico el personaje sleccionado reutilizando codigo, volviendo a abrir el formulario necesario
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                int index = this.listBoxPersonajes.SelectedIndex;
                Personaje personajeAModificar = this.coleccion.listPersonajes[index];

                switch (personajeAModificar)
                {
                    case Arquero:
                        FormArquera formArquera = new FormArquera();
                        this.PersonajeResultCancel(formArquera);
                        if (formArquera.DialogResult == DialogResult.OK && !equalsLista(formArquera.Arqueros))
                        {
                            this.buttonEliminar.PerformClick();
                            this.coleccion += formArquera.Arqueros;
                            this.listBoxPersonajes.Items.Add($"{formArquera.Arqueros.Nombre} - {formArquera.Arqueros.Estilo}");
                            formArquera.Close();
                        }
                        break;

                    case Mago:
                        FormMago formMago = new FormMago();
                        this.PersonajeResultCancel(formMago);
                        if (formMago.DialogResult == DialogResult.OK && !equalsLista(formMago.Magos))
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
                        if (formTanque.DialogResult == DialogResult.OK && !equalsLista(formTanque.Tanques))
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

        //Muestra todos los usuarios logueados, llamando al Form Usuarios
        private void usuariosLogeadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(this.datosUsuarios);
            usuarios.Show();
        }

        //Muestra todos los datos del personaje, llamando al Form MostrarDatos
        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                itemSeleccionado = this.listBoxPersonajes.SelectedIndex;
                MostrarDatos mostrarDatos = new MostrarDatos(this.coleccion.listPersonajes, itemSeleccionado);
                mostrarDatos.Show();
            }
        }

        //Elimina el personaje de la lista dependiendo el index seleccionado utilizando sobrecarga -
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                int posicion = this.listBoxPersonajes.SelectedIndex;
                this.listBoxPersonajes.Items.RemoveAt(posicion);
                Personaje personajeAEliminar = this.coleccion.listPersonajes[posicion];
                this.coleccion = this.coleccion - personajeAEliminar;
            }
        }

        //Gebero metodo que si la lista esta vacia o no seleccione nada, me muestre un mensaje
        public bool devolverMensaje()
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

        //Me pregunta si estoy seguro si deseo cerrar el formulario
        private void Formulario1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la Aplicacion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
