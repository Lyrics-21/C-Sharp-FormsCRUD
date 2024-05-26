﻿using System;
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
    public partial class FormArquera : FormPersonaje
    {
        public FormArquera()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormArquera_Load(object sender, EventArgs e)
        {
            foreach (TipoArco tipoArco in Enum.GetValues(typeof(TipoArco)))
            {
                this.comboBox1.Items.Add(tipoArco);
            }
            this.comboBox1.SelectedItem = TipoArco.Madera;
        }
    }
}