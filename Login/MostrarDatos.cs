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

namespace Forms
{
    public partial class MostrarDatos : Form
    {
        private List<Personaje> listaPersonaje;
        public MostrarDatos(List<Personaje> listaPersonaje)
        {
            InitializeComponent();
            this.listaPersonaje = listaPersonaje;
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            if (this.listaPersonaje.Count > 0)
            {
                foreach (Personaje personaje in this.listaPersonaje)
                {
                    this.richTextBox1.AppendText(personaje.ToString());
                }
            }
            else
            {
                MessageBox.Show("NO");
            }
        }
    }
}
