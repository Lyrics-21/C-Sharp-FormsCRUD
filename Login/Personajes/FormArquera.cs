using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormArquera : FormPersonaje
    {
        public FormArquera()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormArquera_Load(object sender, EventArgs e)
        {
            this.enumCombobox(typeof(TipoArco), this.comboBox1);
            this.comboBox1.SelectedItem = TipoArco.Madera;
        }

        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            base.buttonConfirmar_Click (sender, e);

            TipoArco tipoArco = (TipoArco)Enum.Parse(typeof(TipoArco), this.comboBox1.SelectedItem.ToString());
            try
            {
                Arquero arquero = new Arquero(int.Parse(this.textBoxVida.Text), this.textBoxNombre.Text, int.Parse(this.textBoxNivel.Text), "Arquero", int.Parse(this.textBoxDaño.Text),
                    tipoArco, int.Parse(this.textBoxFlechas.Text));

                this.personaje = arquero;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos validos", "Error", MessageBoxButtons.OK);
            }

        }
        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBox2);
        }

        private void textBoxFlechas_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxFlechas);
        }
    }
}
