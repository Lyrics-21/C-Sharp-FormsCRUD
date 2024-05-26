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
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBoxMana = new TextBox();
            label7 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxMana);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(10, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 140);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 29);
            comboBox1.TabIndex = 3;
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
            Controls.Add(groupBox2);
            Name = "FormMago";
            Text = "FormMago";
            Load += FormMago_Load;
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox textBoxMana;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
    }
}