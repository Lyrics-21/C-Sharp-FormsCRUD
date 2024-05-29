using Libreria_De_Clases;
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
        protected Arquero arqueros;
        protected Mago magos;
        protected Tanque tanques;
        public FormPersonaje()
        {
            InitializeComponent();
        }
        protected virtual void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text.Length <= 0)
            {
                this.label6.Visible = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.ClearText(this.groupBoxPersonaje);
            this.ClearGroupBox();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxVida_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxVida);
        }

        private void textBoxNivel_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxNivel);
        }

        private void textBoxDaño_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxDaño);
        }

        public void ClearText(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        protected virtual void ClearGroupBox()
        {
        }

        protected void ResetTextBoxClick(TextBox textBox)
        {
            if (textBox.ForeColor != Color.Black)
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
            }
        }

        protected void enumCombobox(Type tipoEnum, ComboBox comboBox)
        {
            foreach (Enum item in Enum.GetValues(tipoEnum))
            {
                comboBox.Items.Add(item);
            }
        }

        public Arquero Arqueros
        {
            get { return this.arqueros; }
        }  
        public Tanque Tanques
        {
            get { return this.tanques; }
        }    
        public Mago Magos
        {
            get { return this.magos; }
        }

        public bool validarDatos(TextBox textBox, out int resultado)
        {
            bool retorno = false;
            if (textBox.ForeColor != Color.Black && this.textBoxNombre.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                resultado = 0;
                retorno = true;
            }
            if (int.TryParse(textBox.Text, out resultado) && resultado >= 0&& textBox.Text.Length <= 6 && this.textBoxNombre.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                retorno = true;
            }
            else if (textBox.ForeColor == Color.Black)
            {
                MessageBox.Show("Ingrese datos válidos", "Error", MessageBoxButtons.OK);
                retorno = false;
            }
            return retorno;
        }
    }
}
