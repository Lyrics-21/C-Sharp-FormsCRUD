using Biblioteca_Clases;
using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        private List<Personaje> personajesSrlz = new List<Personaje>(); //no se usa por ahora

        private Coleccion coleccion;
        private int itemSeleccionado;
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
            datoNombre = ObtenerDato.DatoNombre;
            DateTime dateTime = DateTime.Now;
            this.toolStripStatusLabel1.Text = $"{datoNombre} - Logeado - {dateTime.Date.ToString("dd/MM/yyyy")}";

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
                                case "Arquero":
                                    Arquero arquero = System.Text.Json.JsonSerializer.Deserialize<Arquero>(element.GetRawText());
                                    this.coleccion += arquero;
                                    break;

                                case "Mago":
                                    Libreria_De_Clases.Mago mago = System.Text.Json.JsonSerializer.Deserialize<Libreria_De_Clases.Mago>(element.GetRawText());
                                    this.coleccion += mago;
                                    break;

                                case "Tanque":
                                    Libreria_De_Clases.Tanque tanque = System.Text.Json.JsonSerializer.Deserialize<Libreria_De_Clases.Tanque>(element.GetRawText());
                                    this.coleccion += tanque;
                                    break;
                            }
                        }
                        foreach (Personaje personaje in this.coleccion.listPersonajes)
                        {
                            this.listBoxPersonajes.Items.Add($"{personaje.Nombre} - {personaje.Estilo}");
                        }
                    }
                }
            }
            catch (System.Text.Json.JsonException ex)
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
        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMago formMago = new FormMago();
            this.PersonajeResultCancel(formMago);
            if (formMago.DialogResult == DialogResult.OK)
            {
                this.coleccion += formMago.Magos;
                this.listBoxPersonajes.Items.Add($"{formMago.Magos.Nombre} - {formMago.Magos.Estilo}");
                formMago.Close();
            }
        }
        private void arqueroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormArquera formArquera = new FormArquera();
            this.PersonajeResultCancel(formArquera);
            if (formArquera.DialogResult == DialogResult.OK)
            {
                this.coleccion += formArquera.Arqueros;
                this.listBoxPersonajes.Items.Add($"{formArquera.Arqueros.Nombre} - {formArquera.Arqueros.Estilo}");
                formArquera.Close();
            }
        }
        private void tanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTanque formTanque = new FormTanque();
            this.PersonajeResultCancel(formTanque);
            if (formTanque.DialogResult == DialogResult.OK)
            {
                this.coleccion += formTanque.Tanques;
                this.listBoxPersonajes.Items.Add($"{formTanque.Tanques.Nombre} - {formTanque.Tanques.Estilo}");
                formTanque.Close();
            }
        }
        private void guardarPersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string archivoJson = System.Text.Json.JsonSerializer.Serialize(this.coleccion.listPersonajes);
                File.WriteAllText(this.pathPersonajes, archivoJson);
            }
            catch (System.Text.Json.JsonException ex)
            {
                MessageBox.Show($"Ocurrio un error al serializar el archivo\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
                        if (formArquera.DialogResult == DialogResult.OK)
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
                        if (formMago.DialogResult == DialogResult.OK)
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
                        if (formTanque.DialogResult == DialogResult.OK)
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
        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                itemSeleccionado = this.listBoxPersonajes.SelectedIndex;
                MostrarDatos mostrarDatos = new MostrarDatos(this.coleccion.listPersonajes, itemSeleccionado);
                mostrarDatos.Show();
            }
        }
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
