using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Forms.FormLogin;

namespace Forms
{
    public partial class FormPersonaje : Form
    {
        public FormPersonaje()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.label6.Visible = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxVida_Click(object sender, EventArgs e)
        {
            if (this.textBoxVida.ForeColor != Color.Black)
            {
                this.textBoxVida.Clear();
                this.textBoxVida.ForeColor = Color.Black;
            }
        }

        private void textBoxNivel_Click(object sender, EventArgs e)
        {
            if (this.textBoxNivel.ForeColor != Color.Black)
            {
                this.textBoxNivel.Clear();
                this.textBoxNivel.ForeColor = Color.Black;
            }
        }

        private void textBoxDaño_Click(object sender, EventArgs e)
        {
            if (this.textBoxDaño.ForeColor != Color.Black)
            {
                this.textBoxDaño.Clear();
                this.textBoxDaño.ForeColor = Color.Black;
            }
        }
    }
}
