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
            //Llamo al metodo EnumComboBox para agregar el enumerado de Tanque a mi comboBox 
            FormPersonaje.EnumCombobox(typeof(TipoArmadura), this.comboBoxTanque);
            this.comboBoxTanque.SelectedItem = TipoArmadura.Cuero;
        }

        //Sobrescribo el boton Confirmar de mi FormPersonaje
        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Llamo lo que el boton de Clase padre hace
            base.buttonConfirmar_Click(sender, e);

            //Instancio mi personaje validando cada dato y combinacion posible
            TipoArmadura tipoArmadura = (TipoArmadura)Enum.Parse(typeof(TipoArmadura), this.comboBoxTanque.SelectedItem.ToString());

            int vida, daño, nivel, fuerza;

            if (ValidarDatos(this.textBoxVida, out vida) && ValidarDatos(this.textBoxDaño, out daño) &&
                ValidarDatos(this.textBoxNivel, out nivel) && ValidarDatos(this.textBoxFuerza, out fuerza))
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
                else if (vida != 0 && daño != 0 && fuerza == 0)
                {
                    Tanque tanque7 = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura);
                    this.tanques = tanque7;
                }
                else if (vida != 0 && daño != 0 && fuerza != 0)
                {
                    Tanque tanque8 = new Tanque(vida, this.textBoxNombre.Text, nivel, "Tanque", daño, tipoArmadura, fuerza);
                    this.tanques = tanque8;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        //Sobrescribo ClearGroupBox y Llamo a ClearText de Personaje para limpiar los valores de groupBoxTanque
        protected override void ClearGroupBox()
        {
            FormPersonaje.ClearText(this.groupBoxTanque);
        }

        //Si presiono Fuerza lo limpia llamando a ResetTextBoxClick de clase padre
        private void textBoxFuerza_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxFuerza);
        }
    }
}
