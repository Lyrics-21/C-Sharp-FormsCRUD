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
        private List<string> listJson = new List<string>();
        private string pathPersonajes;
        private List<string> personajesDsrlz = new List<string>();
        public Formulario1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;
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
                        this.personajesDsrlz = System.Text.Json.JsonSerializer.Deserialize<List<string>>(archivoJson);
                    }
                }

                foreach (string personaje in this.personajesDsrlz)
                {
                    this.listaPersonajes.Items.Add(personaje);
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

            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (devolverMensaje())
            {
                MessageBox.Show("GORDITO");
            }
        }
        private void guardarPersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string items in this.listaPersonajes.Items)
                {
                    this.listJson.Add(items.ToString());
                }
                string archivoJson = System.Text.Json.JsonSerializer.Serialize(this.listJson);
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
            if (this.listaPersonajes.Items.Count <= 0)
            {
                MessageBox.Show("Agrege un Personaje", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                estado = false;
            }
            else if (this.listaPersonajes.SelectedIndex <= -1)
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
