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
                //Instanciar al Personaje sin los atributos de cada if con todas las combinaciones posibles
                if (vida == 0 && daño == 0 && mana == 0)
                {
                    Mago mago1 = new Mago(this.textBoxNombre.Text, nivel, "Mago", tipoMagia);
                    this.magos = mago1;
                }
                else if (vida == 0 && daño == 0 && mana != 0)
                {
                    Mago mago2 = new Mago(this.textBoxNombre.Text, nivel, "Mago", tipoMagia, mana);
                    this.magos = mago2;
                }
                else if (vida == 0 && daño != 0 && mana == 0)
                {
                    Mago mago3 = new Mago(this.textBoxNombre.Text, nivel, "Mago", daño, tipoMagia);
                    this.magos = mago3;
                }
                else if (vida == 0 && daño != 0 && mana != 0)
                {
                    Mago mago4 = new Mago(this.textBoxNombre.Text, nivel, "Mago", daño, tipoMagia, mana);
                    this.magos = mago4;
                }
                else if (vida != 0 && daño == 0 && mana == 0)
                {
                    Mago mago5 = new Mago(vida, this.textBoxNombre.Text, nivel, "Mago", tipoMagia);
                    this.magos = mago5;
                }
                else if (vida != 0 && daño == 0 && mana != 0)
                {
                    Mago mago6 = new Mago(vida, this.textBoxNombre.Text, nivel, "Mago", tipoMagia, mana);
                    this.magos = mago6;
                }
                else if (vida != 0 && daño != 0 && mana == 0)
                {
                    Mago mago7 = new Mago(vida, this.textBoxNombre.Text, nivel, "Mago", daño, tipoMagia);
                    this.magos = mago7;
                }
                else if (vida != 0 && daño != 0 && mana != 0)
                {
                    Mago mago8 = new Mago(vida, this.textBoxNombre.Text, nivel, "Mago", daño, tipoMagia, mana);
                    this.magos = mago8;
                }
                this.DialogResult = DialogResult.OK;
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
