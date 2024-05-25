using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.listBox1.Items.Add("Personaje");
        }

        private void mAgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PEDAZOO", "N A Z I", MessageBoxButtons.OK);
        }

        private void tanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
            formDatos.ShowDialog();
            if (formDatos.DialogResult == DialogResult.Cancel)
            {
                formDatos.Close();
            }
        }
        public void devolverMensaje()
        {
            if (this.listBox1.Items.Count <= 0)
            {
                MessageBox.Show("Agrege un Personaje", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox1.SelectedIndex >= -1)
            {
                MessageBox.Show("Seleccione un personaje", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string items in this.listBox1.Items)
            {
                listJson.Add(items.ToString());
            }
            string pathPersonajes = "C:\\Users\\Lyrics\\Desktop\\UTN\\Programacion 2\\Parcial Elian Viana";
            string archivoJson = System.Text.Json.JsonSerializer.Serialize(listJson);
            File.WriteAllText(pathPersonajes, archivoJson);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
