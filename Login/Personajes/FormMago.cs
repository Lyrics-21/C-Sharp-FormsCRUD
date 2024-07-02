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
            //Llamo al metodo EnumComboBox para agregar el enumerado de Mago a mi comboBox 
            FormPersonaje.EnumCombobox(typeof(TipoMagia), this.comboBoxMago);
            this.comboBoxMago.SelectedItem = TipoMagia.Elemental;
        }

        //Sobrescribo el boton Confirmar de mi FormPersonaje
        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Llamo lo que el boton de Clase padre hace
            base.buttonConfirmar_Click(sender, e);

            //Instancio mi personaje validando cada dato y combinacion posible
            TipoMagia tipoMagia = (TipoMagia)Enum.Parse(typeof(TipoMagia), this.comboBoxMago.SelectedItem.ToString());

            int vida, daño, nivel, mana;

            if (ValidarDatos(this.textBoxVida, out vida) && ValidarDatos(this.textBoxDaño, out daño) &&
                ValidarDatos(this.textBoxNivel, out nivel) && ValidarDatos(this.textBoxMana, out mana))
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

        //Sobrescribo ClearGroupBox y Llamo a ClearText de Personaje para limpiar los valores de groupBoxMago
        protected override void ClearGroupBox()
        {
            FormPersonaje.ClearText(this.groupBoxMago);
        }

        //Si presiono Mana lo limpia llamando a ResetTextBoxClick de clase padre
        private void textBoxMana_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxMana);
        }
    }
}
