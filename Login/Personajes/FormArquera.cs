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
            this.comboBoxArquero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormArquera_Load(object sender, EventArgs e)
        {
            //Llamo al metodo EnumComboBox para agregar el enumerado de Arquero a mi comboBox 
            FormPersonaje.EnumCombobox(typeof(TipoArco), this.comboBoxArquero);
            this.comboBoxArquero.SelectedItem = TipoArco.Madera;
        }

        //Sobrescribo el boton Confirmar de mi FormPersonaje
        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Llamo lo que el boton de Clase padre hace
            base.buttonConfirmar_Click(sender, e);

            //Instancio mi personaje validando cada dato y combinacion posible
            TipoArco tipoArco = (TipoArco)Enum.Parse(typeof(TipoArco), this.comboBoxArquero.SelectedItem.ToString());

            int vida, daño, nivel, cantidadFlechas;

            if (ValidarDatos(this.textBoxVida, out vida) && ValidarDatos(this.textBoxDaño, out daño) &&
                ValidarDatos(this.textBoxNivel, out nivel) && ValidarDatos(this.textBoxFlechas, out cantidadFlechas))
            {
                //Instanciar al Personaje sin los atributos de cada if con todas las combinaciones posibles
                if (vida == 0 && daño == 0 && cantidadFlechas == 0)
                {
                    Arquero arquero1 = new Arquero(this.textBoxNombre.Text, nivel, "Arquero/a", tipoArco);
                    this.arqueros = arquero1;
                }
                else if (vida == 0 && daño == 0 && cantidadFlechas != 0)
                {
                    Arquero arquero2 = new Arquero(this.textBoxNombre.Text, nivel, "Arquero/a", tipoArco, cantidadFlechas);
                    this.arqueros = arquero2;
                }
                else if (vida == 0 && daño != 0 && cantidadFlechas == 0)
                {
                    Arquero arquero3 = new Arquero(this.textBoxNombre.Text, nivel, "Arquero/a", daño, tipoArco);
                    this.arqueros = arquero3;
                }
                else if (vida == 0 && daño != 0 && cantidadFlechas != 0)
                {
                    Arquero arquero4 = new Arquero(this.textBoxNombre.Text, nivel, "Arquero/a", daño, tipoArco, cantidadFlechas);
                    this.arqueros = arquero4;
                }
                else if (vida != 0 && daño == 0 && cantidadFlechas == 0)
                {
                    Arquero arquero5 = new Arquero(vida, this.textBoxNombre.Text, nivel, "Arquero/a", tipoArco);
                    this.arqueros = arquero5;
                }
                else if (vida != 0 && daño == 0 && cantidadFlechas != 0)
                {
                    Arquero arquero6 = new Arquero(vida, this.textBoxNombre.Text, nivel, "Arquero/a", tipoArco, cantidadFlechas);
                    this.arqueros = arquero6;
                }
                else if (vida != 0 && daño != 0 && cantidadFlechas == 0)
                {
                    Arquero arquero7 = new Arquero(vida, this.textBoxNombre.Text, nivel, "Arquero/a", daño, tipoArco);
                    this.arqueros = arquero7;
                }
                else if (vida != 0 && daño != 0 && cantidadFlechas != 0)
                {
                    Arquero arquero8 = new Arquero(vida, this.textBoxNombre.Text, nivel, "Arquero/a", daño, tipoArco, cantidadFlechas);
                    this.arqueros = arquero8;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        //Sobrescribo ClearGroupBox y Llamo a ClearText de Personaje para limpiar los valores de groupBoxArquero
        protected override void ClearGroupBox()
        {
            FormPersonaje.ClearText(this.groupBoxArquero);
        }

        //Si presiono Cantidad Flechas lo limpia llamando a ResetTextBoxClick de clase padre
        private void textBoxFlechas_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxFlechas);
        }
    }
}
