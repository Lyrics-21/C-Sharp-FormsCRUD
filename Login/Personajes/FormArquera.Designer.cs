namespace Forms
{
    partial class FormArquera
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
            label6 = new Label();
            textBoxFlechas = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            groupBoxArquero = new GroupBox();
            groupBoxArquero.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 36);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 8;
            label6.Text = "Cantidad de flechas :";
            // 
            // textBoxFlechas
            // 
            textBoxFlechas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFlechas.ForeColor = SystemColors.ButtonShadow;
            textBoxFlechas.Location = new Point(194, 33);
            textBoxFlechas.Name = "textBoxFlechas";
            textBoxFlechas.Size = new Size(168, 29);
            textBoxFlechas.TabIndex = 9;
            textBoxFlechas.Text = "     Valor por defecto";
            textBoxFlechas.Click += textBoxFlechas_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 89);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 10;
            label7.Text = "Tipo de arco :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 29);
            comboBox1.TabIndex = 11;
            // 
            // groupBoxArquero
            // 
            groupBoxArquero.Controls.Add(textBoxFlechas);
            groupBoxArquero.Controls.Add(comboBox1);
            groupBoxArquero.Controls.Add(label6);
            groupBoxArquero.Controls.Add(label7);
            groupBoxArquero.Location = new Point(10, 310);
            groupBoxArquero.Name = "groupBoxArquero";
            groupBoxArquero.Size = new Size(402, 142);
            groupBoxArquero.TabIndex = 12;
            groupBoxArquero.TabStop = false;
            // 
            // FormArquera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 520);
            Controls.Add(groupBoxArquero);
            Name = "FormArquera";
            Text = "FormArquero";
            Load += FormArquera_Load;
            Controls.SetChildIndex(groupBoxArquero, 0);
            groupBoxArquero.ResumeLayout(false);
            groupBoxArquero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private TextBox textBoxFlechas;
        private Label label7;
        private ComboBox comboBox1;
        private GroupBox groupBoxArquero;
    }
}