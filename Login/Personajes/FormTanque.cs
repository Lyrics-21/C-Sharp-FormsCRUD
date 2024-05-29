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
    public partial class FormTanque : FormPersonaje
    {
        public FormTanque()
        {
            InitializeComponent();
            this.comboBoxTanque.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormTanque_Load(object sender, EventArgs e)
        {
            this.enumCombobox(typeof(TipoArmadura), this.comboBoxTanque);
            this.comboBoxTanque.SelectedItem = TipoArmadura.Cuero;
        }

        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            base.buttonConfirmar_Click(sender, e);

            TipoArmadura tipoArmadura = (TipoArmadura)Enum.Parse(typeof(TipoArmadura), this.comboBoxTanque.SelectedItem.ToString());

            int vida, daño, nivel, fuerza;

            if (validarDatos(this.textBoxVida, out vida) && validarDatos(this.textBoxDaño, out daño) &&
                validarDatos(this.textBoxNivel, out nivel) && validarDatos(this.textBoxFuerza, out fuerza))
            {
                Tanque tanque = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura, fuerza);
                this.tanques = tanque;
            }
        }
        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBoxTanque);
        }
        private void textBoxMana_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxFuerza);
        }
    }
}
