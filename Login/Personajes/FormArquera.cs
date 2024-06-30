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
            this.enumCombobox(typeof(TipoArco), this.comboBoxArquero);
            this.comboBoxArquero.SelectedItem = TipoArco.Madera;
        }

        protected override void buttonConfirmar_Click(object sender, EventArgs e)
        {
            base.buttonConfirmar_Click(sender, e);

            TipoArco tipoArco = (TipoArco)Enum.Parse(typeof(TipoArco), this.comboBoxArquero.SelectedItem.ToString());

            int vida, daño, nivel, cantidadFlechas;

            if (validarDatos(this.textBoxVida, out vida) && validarDatos(this.textBoxDaño, out daño) &&
                validarDatos(this.textBoxNivel, out nivel) && validarDatos(this.textBoxFlechas, out cantidadFlechas))
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
