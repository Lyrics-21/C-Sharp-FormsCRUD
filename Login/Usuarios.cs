using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Usuarios : Form
    {
        private string datosUsuario;
        public Usuarios(string datosUsuario)
        {
            InitializeComponent();
            this.datosUsuario = datosUsuario;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.datosUsuario;
        }
    }
}
