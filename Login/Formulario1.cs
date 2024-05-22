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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.toolStripStatusLabel1.Text = $"Logeado {dateTime.Date}"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
