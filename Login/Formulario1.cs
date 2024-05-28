using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Forms.FormLogin;

namespace Forms
{
    public partial class Formulario1 : Form
    {
        private string datoNombre;
        private string pathPersonajes;
        private List<Personaje> personajesDsrlz = new List<Personaje>();

        private List<Personaje> listPersonaje;

        private int itemSeleccionado;
        public Formulario1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.listPersonaje = new List<Personaje>();
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
                        this.personajesDsrlz = System.Text.Json.JsonSerializer.Deserialize<List<Personaje>>(archivoJson);
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

        private void magoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arqueroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormArquera formArquera = new FormArquera();
            formArquera.ShowDialog();
            if (formArquera.DialogResult == DialogResult.Cancel)
            {
                formArquera.Close();
            }
            else if (formArquera.DialogResult == DialogResult.OK)
            {
                this.listPersonaje.Add(formArquera.GetPersonaje);
                this.listBoxPersonajes.Items.Add(formArquera.GetPersonaje);
                formArquera.Close();
            }
        }

        private void tanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                MessageBox.Show("GORDITO");
            }
        }
        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                itemSeleccionado = this.listBoxPersonajes.SelectedIndex;
                MostrarDatos mostrarDatos = new MostrarDatos(this.listPersonaje, itemSeleccionado);
                mostrarDatos.Show();
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                this.listBoxPersonajes.Items.RemoveAt(this.listBoxPersonajes.SelectedIndex);
            }
        }
        private void guardarPersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Personaje> list = new List<Personaje>();
                foreach (Personaje item in this.listPersonaje)
                {
                    list.Add(item);
                }
                string archivoJson = System.Text.Json.JsonSerializer.Serialize(list);
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

    }
}
