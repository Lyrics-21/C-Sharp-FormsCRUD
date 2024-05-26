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
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormMago_Load(object sender, EventArgs e)
        {
            this.enumCombobox(typeof(TipoMagia), this.comboBox1);
            this.comboBox1.SelectedItem = TipoMagia.Elemental;
        }

        private void textBoxMana_Click(object sender, EventArgs e)
        {
            this.ResetTextBoxClick(this.textBoxMana);
        }
    }
}
