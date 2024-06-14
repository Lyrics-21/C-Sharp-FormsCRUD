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
                //Instanciar al Personaje sin los atributos de cada if con todas las combinaciones posibles
                if (vida == 0 && daño == 0 && fuerza == 0)
                {
                    Tanque tanque1 = new Tanque(this.textBoxNombre.Text, nivel, "Tanque", tipoArmadura);
                    this.tanques = tanque1;
                }
                else if (vida == 0 && daño == 0 && fuerza != 0)
                {
                    Tanque tanque2 = new Tanque(this.textBoxNombre.Text, nivel, "Tanque", tipoArmadura, fuerza);
                    this.tanques = tanque2;
                }
                else if (vida == 0 && daño != 0 && fuerza == 0)
                {
                    Tanque tanque3 = new Tanque(this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura);
                    this.tanques = tanque3;
                }
                else if (vida == 0 && daño != 0 && fuerza != 0)
                {
                    Tanque tanque4 = new Tanque(this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura, fuerza);
                    this.tanques = tanque4;
                }
                else if (vida != 0 && daño == 0 && fuerza == 0)
                {
                    Tanque tanque5 = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", tipoArmadura);
                    this.tanques = tanque5;
                }
                else if (vida != 0 && daño == 0 && fuerza != 0)
                {
                    Tanque tanque6 = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", tipoArmadura, fuerza);
                    this.tanques = tanque6;
                }
                else if (vida != 0 && daño != 0 && fuerza != 0)
                {
                    Tanque tanque7 = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura, fuerza);
                    this.tanques = tanque7;
                }
                this.DialogResult = DialogResult.OK;
            }
        }
        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBoxTanque);
        }

        private void textBoxFuerza_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxFuerza);
        }
    }
}
