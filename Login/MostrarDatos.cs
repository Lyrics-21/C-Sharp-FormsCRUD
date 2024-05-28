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
        private int itemSeleccionado;
        public MostrarDatos(List<Personaje> listaPersonaje, int itemSeleccionado)
        {
            InitializeComponent();
            this.listaPersonaje = listaPersonaje;
            this.itemSeleccionado = itemSeleccionado;
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            Personaje personaje = this.listaPersonaje[itemSeleccionado];
            this.richTextBox1.Text = personaje.ToString();
        }
    }
}
