namespace Forms
{
    partial class FormPersonaje
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
            label1 = new Label();
            panel1 = new Panel();
            buttonConfirmar = new Button();
            buttonCancelar = new Button();
            buttonLimpiar = new Button();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxVida = new TextBox();
            label4 = new Label();
            textBoxNivel = new TextBox();
            label5 = new Label();
            textBoxDaño = new TextBox();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "Datos del personaje";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 52);
            panel1.TabIndex = 1;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(39, 10);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(98, 32);
            buttonConfirmar.TabIndex = 5;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(297, 10);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 32);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(169, 10);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(98, 32);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 31);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre :";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(127, 28);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(168, 29);
            textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 88);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Vida :";
            // 
            // textBoxVida
            // 
            textBoxVida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVida.ForeColor = SystemColors.ButtonShadow;
            textBoxVida.Location = new Point(127, 85);
            textBoxVida.Name = "textBoxVida";
            textBoxVida.Size = new Size(168, 29);
            textBoxVida.TabIndex = 3;
            textBoxVida.Text = "     Valor por defecto";
            textBoxVida.Click += textBoxVida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 143);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 4;
            label4.Text = "Nivel :";
            // 
            // textBoxNivel
            // 
            textBoxNivel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNivel.ForeColor = SystemColors.ButtonShadow;
            textBoxNivel.Location = new Point(127, 140);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(168, 29);
            textBoxNivel.TabIndex = 5;
            textBoxNivel.Text = "     Valor por defecto";
            textBoxNivel.Click += textBoxNivel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 199);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 6;
            label5.Text = "Daño :";
            // 
            // textBoxDaño
            // 
            textBoxDaño.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDaño.ForeColor = SystemColors.ButtonShadow;
            textBoxDaño.Location = new Point(127, 196);
            textBoxDaño.Name = "textBoxDaño";
            textBoxDaño.Size = new Size(168, 29);
            textBoxDaño.TabIndex = 7;
            textBoxDaño.Text = "     Valor por defecto";
            textBoxDaño.Click += textBoxDaño_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(textBoxDaño);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxVida);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxNivel);
            groupBox1.Location = new Point(10, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 247);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonConfirmar);
            panel2.Controls.Add(buttonLimpiar);
            panel2.Location = new Point(-4, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 52);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 60);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 8;
            label6.Text = "Ingrese un nombre";
            label6.Visible = false;
            // 
            // FormPersonaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 522);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormPersonaje";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personaje";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button buttonConfirmar;
        private Button buttonCancelar;
        private Button buttonLimpiar;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxVida;
        private Label label4;
        private TextBox textBoxNivel;
        private Label label5;
        private TextBox textBoxDaño;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label6;
    }
}