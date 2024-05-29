namespace Forms
{
    partial class FormTanque
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
            label7 = new Label();
            label8 = new Label();
            groupBoxTanque = new GroupBox();
            comboBoxTanque = new ComboBox();
            textBoxFuerza = new TextBox();
            groupBoxTanque.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 35);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 9;
            label7.Text = "Cantidad de Fuerza :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(62, 91);
            label8.Name = "label8";
            label8.Size = new Size(140, 21);
            label8.TabIndex = 10;
            label8.Text = "Tipo de armadura :";
            // 
            // groupBoxTanque
            // 
            groupBoxTanque.Controls.Add(comboBoxTanque);
            groupBoxTanque.Controls.Add(textBoxFuerza);
            groupBoxTanque.Controls.Add(label8);
            groupBoxTanque.Controls.Add(label7);
            groupBoxTanque.Location = new Point(11, 312);
            groupBoxTanque.Name = "groupBoxTanque";
            groupBoxTanque.Size = new Size(402, 141);
            groupBoxTanque.TabIndex = 11;
            groupBoxTanque.TabStop = false;
            // 
            // comboBoxTanque
            // 
            comboBoxTanque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTanque.FormattingEnabled = true;
            comboBoxTanque.Location = new Point(208, 88);
            comboBoxTanque.Name = "comboBoxTanque";
            comboBoxTanque.Size = new Size(164, 29);
            comboBoxTanque.TabIndex = 12;
            // 
            // textBoxFuerza
            // 
            textBoxFuerza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFuerza.ForeColor = SystemColors.ButtonShadow;
            textBoxFuerza.Location = new Point(208, 32);
            textBoxFuerza.Name = "textBoxFuerza";
            textBoxFuerza.Size = new Size(164, 29);
            textBoxFuerza.TabIndex = 11;
            textBoxFuerza.Text = "     Valor por defecto";
            textBoxFuerza.Click += textBoxFuerza_Click;
            // 
            // FormTanque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 522);
            Controls.Add(groupBoxTanque);
            Name = "FormTanque";
            Text = "Tanque";
            Load += FormTanque_Load;
            Controls.SetChildIndex(groupBoxTanque, 0);
            groupBoxTanque.ResumeLayout(false);
            groupBoxTanque.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Label label8;
        private GroupBox groupBoxTanque;
        private ComboBox comboBoxTanque;
        private TextBox textBoxFuerza;
    }
}