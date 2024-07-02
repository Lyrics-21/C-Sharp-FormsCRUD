using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Forms.FormLogin;

namespace Forms
{
    public partial class FormPersonaje : Form
    {
        //Estos atributos guardan el Personaje instanciado
        protected Arquero arqueros;
        protected Mago magos;
        protected Tanque tanques;
        public FormPersonaje()
        {
            InitializeComponent();
        }

        #region Botones

        //El evento Click es virtual porque lo sobrescribo en las clases derivadas
        protected virtual void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text.Length <= 0)
            {
                this.label6.Visible = true;
            }
        }

        //Llamo a dos metodos cuando presiona Limpiar
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            FormPersonaje.ClearText(this.groupBoxPersonaje);
            this.ClearGroupBox();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Los siguientes 3 eventos son solamente esteticos, si presiono el textBox llama a un metodo
        private void textBoxVida_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxVida);
        }

        private void textBoxNivel_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxNivel);
        }

        private void textBoxDaño_Click(object sender, EventArgs e)
        {
            FormPersonaje.ResetTextBoxClick(this.textBoxDaño);
        }

        #endregion

        #region Metodos

        //Este metodo estatico lo utilizo para limpiar los groupBox
        public static void ClearText(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        //Genero un metodo virtual para sobrescribirlos en las clases derivadas
        protected virtual void ClearGroupBox()
        {
        }

        //Este metodo limpia y resetea el color de los textBox
        protected static void ResetTextBoxClick(TextBox textBox)
        {
            if (textBox.ForeColor != Color.Black)
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
            }
        }

        //Este metodo agrega los enumerados a mi Combobox en clases derivadas
        protected static void EnumCombobox(Type tipoEnum, ComboBox comboBox)
        {
            foreach (Enum item in Enum.GetValues(tipoEnum))
            {
                comboBox.Items.Add(item);
            }
        }

        //Genero propiedades para retornar los distintos personajes que instancie en clases derivadas
        public Arquero Arqueros
        {
            get { return this.arqueros; }
        }
        public Tanque Tanques
        {
            get { return this.tanques; }
        }
        public Mago Magos
        {
            get { return this.magos; }
        }

        //Este metodo valida todos los datos ingresados por el usuario antes de agregarlos como atributos al Personaje instanciado
        public bool ValidarDatos(TextBox textBox, out int resultado)
        {
            bool retorno = false;
            if (textBox.ForeColor != Color.Black && this.textBoxNombre.Text.Length > 0)
            {
                resultado = 0;
                retorno = true;
            }
            if (int.TryParse(textBox.Text, out resultado) && resultado >= 0 && textBox.Text.Length <= 6 && this.textBoxNombre.Text.Length > 0)
            {
                retorno = true;
            }
            else if (textBox.ForeColor == Color.Black)
            {
                MessageBox.Show("Ingrese datos válidos", "Error", MessageBoxButtons.OK);
                retorno = false;
            }
            return retorno;
        }

        #endregion
    }
}
