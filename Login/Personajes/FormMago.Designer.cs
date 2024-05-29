namespace Forms
{
    partial class FormMago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxMago = new GroupBox();
            comboBoxMago = new ComboBox();
            label8 = new Label();
            textBoxMana = new TextBox();
            label7 = new Label();
            groupBoxMago.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMago
            // 
            groupBoxMago.Controls.Add(comboBoxMago);
            groupBoxMago.Controls.Add(label8);
            groupBoxMago.Controls.Add(textBoxMana);
            groupBoxMago.Controls.Add(label7);
            groupBoxMago.Location = new Point(10, 313);
            groupBoxMago.Name = "groupBoxMago";
            groupBoxMago.Size = new Size(402, 140);
            groupBoxMago.TabIndex = 9;
            groupBoxMago.TabStop = false;
            // 
            // comboBoxMago
            // 
            comboBoxMago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMago.FormattingEnabled = true;
            comboBoxMago.Location = new Point(199, 86);
            comboBoxMago.Name = "comboBoxMago";
            comboBoxMago.Size = new Size(162, 29);
            comboBoxMago.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(78, 89);
            label8.Name = "label8";
            label8.Size = new Size(115, 21);
            label8.TabIndex = 2;
            label8.Text = "Tipo de Magia :";
            // 
            // textBoxMana
            // 
            textBoxMana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMana.ForeColor = SystemColors.ButtonShadow;
            textBoxMana.Location = new Point(197, 31);
            textBoxMana.Name = "textBoxMana";
            textBoxMana.Size = new Size(164, 29);
            textBoxMana.TabIndex = 1;
            textBoxMana.Text = "     Valor por defecto";
            textBoxMana.Click += textBoxMana_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 34);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 0;
            label7.Text = "Cantidad de Mana :";
            // 
            // FormMago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 522);
            Controls.Add(groupBoxMago);
            Name = "FormMago";
            Text = "Mago";
            Load += FormMago_Load;
            Controls.SetChildIndex(groupBoxMago, 0);
            groupBoxMago.ResumeLayout(false);
            groupBoxMago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMago;
        private TextBox textBoxMana;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxMago;
    }
}