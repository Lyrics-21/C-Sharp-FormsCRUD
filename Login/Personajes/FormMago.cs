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
    public partial class FormMago : FormPersonaje
    {
        public FormMago()
        {
            InitializeComponent();
            this.comboBoxMago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormMago_Load(object sender, EventArgs e)
        {
            this.enumCombobox(typeof(TipoMagia), this.comboBoxMago);
            this.comboBoxMago.SelectedItem = TipoMagia.Elemental;
        }
        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            base.buttonConfirmar_Click(sender, e);

            TipoMagia tipoMagia = (TipoMagia)Enum.Parse(typeof(TipoMagia), this.comboBoxMago.SelectedItem.ToString());

            int vida, daño, nivel, mana;

            if (validarDatos(this.textBoxVida, out vida) && validarDatos(this.textBoxDaño, out daño) &&
                validarDatos(this.textBoxNivel, out nivel) && validarDatos(this.textBoxMana, out mana))
            {
                Libreria_De_Clases.Mago mago = new Libreria_De_Clases.Mago(vida, this.textBoxNombre.Text, nivel, "Mago/a", daño, tipoMagia, mana);
                this.magos = mago;
            }
        }
        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBoxMago);
        }
        private void textBoxMana_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxMana);
        }
    }
}
