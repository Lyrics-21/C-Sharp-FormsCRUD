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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

            int vida, daño, nivel, cantidadFlechas;

            if(validarDatos(this.textBoxVida, out vida) && validarDatos(this.textBoxDaño, out daño) &&
                validarDatos(this.textBoxNivel, out nivel) && validarDatos(this.textBoxFlechas, out cantidadFlechas))
            {
                Arquero arquero = new Arquero(vida, this.textBoxNombre.Text, nivel, "Arquero/a", daño, tipoArco, cantidadFlechas);
                this.arqueros = arquero;
            }
        }
        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBoxArquero);
        }

        private void textBoxFlechas_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxFlechas);
        }
    }
}
