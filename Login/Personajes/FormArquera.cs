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

namespace Forms
{
    public partial class FormArquera : FormPersonaje
    {
        public FormArquera()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Arquero arquero = new Arquero(1000, "Darwin", 21, "Arquero", 100, TipoArco.Magico, 20);
            this.PersonajeList.Add(arquero);
        }

        private void FormArquera_Load(object sender, EventArgs e)
        {
            this.enumCombobox(typeof(TipoArco), this.comboBox1);
            this.comboBox1.SelectedItem = TipoArco.Madera;
        }

        protected override void ClearGroupBox()
        {
            this.ClearText(this.groupBox2);
        }

        private void textBoxFlechas_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxFlechas);
        }

        public List<Personaje> GetLista
        {
            get 
            { 
                return this.PersonajeList; 
            }
        }
    }
}
