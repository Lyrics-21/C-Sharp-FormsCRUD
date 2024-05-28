namespace Forms
{
    partial class Formulario1
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
            label3 = new Label();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            agregarPersonajeToolStripMenuItem = new ToolStripMenuItem();
            magoToolStripMenuItem = new ToolStripMenuItem();
            arqueroToolStripMenuItem = new ToolStripMenuItem();
            tanqueToolStripMenuItem = new ToolStripMenuItem();
            guardarPersonajesToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            listBoxPersonajes = new ListBox();
            buttonMostrarDatos = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 5;
            label3.Text = "Datos del Personaje :";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(425, 537);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(162, 34);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(12, 537);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(160, 34);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(599, 27);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = SystemColors.ControlDark;
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPersonajeToolStripMenuItem, guardarPersonajesToolStripMenuItem, guardarComoToolStripMenuItem });
            agregarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            agregarToolStripMenuItem.MergeIndex = 1;
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(125, 23);
            agregarToolStripMenuItem.Text = "Agregar/Guardar";
            // 
            // agregarPersonajeToolStripMenuItem
            // 
            agregarPersonajeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { magoToolStripMenuItem, arqueroToolStripMenuItem, tanqueToolStripMenuItem });
            agregarPersonajeToolStripMenuItem.Name = "agregarPersonajeToolStripMenuItem";
            agregarPersonajeToolStripMenuItem.Size = new Size(189, 24);
            agregarPersonajeToolStripMenuItem.Text = "Agregar Personaje";
            // 
            // magoToolStripMenuItem
            // 
            magoToolStripMenuItem.Name = "magoToolStripMenuItem";
            magoToolStripMenuItem.Size = new Size(128, 24);
            magoToolStripMenuItem.Text = "Mago";
            magoToolStripMenuItem.Click += magoToolStripMenuItem_Click;
            // 
            // arqueroToolStripMenuItem
            // 
            arqueroToolStripMenuItem.Name = "arqueroToolStripMenuItem";
            arqueroToolStripMenuItem.Size = new Size(128, 24);
            arqueroToolStripMenuItem.Text = "Arquero";
            arqueroToolStripMenuItem.Click += arqueroToolStripMenuItem_Click;
            // 
            // tanqueToolStripMenuItem
            // 
            tanqueToolStripMenuItem.Name = "tanqueToolStripMenuItem";
            tanqueToolStripMenuItem.Size = new Size(128, 24);
            tanqueToolStripMenuItem.Text = "Tanque";
            tanqueToolStripMenuItem.Click += tanqueToolStripMenuItem_Click;
            // 
            // guardarPersonajesToolStripMenuItem
            // 
            guardarPersonajesToolStripMenuItem.Name = "guardarPersonajesToolStripMenuItem";
            guardarPersonajesToolStripMenuItem.Size = new Size(189, 24);
            guardarPersonajesToolStripMenuItem.Text = "Guardar";
            guardarPersonajesToolStripMenuItem.Click += guardarPersonajesToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(189, 24);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ButtonShadow;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 586);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(599, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusLog";
            // 
            // listaPersonajes
            // 
            listBoxPersonajes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPersonajes.FormattingEnabled = true;
            listBoxPersonajes.ItemHeight = 17;
            listBoxPersonajes.Location = new Point(12, 56);
            listBoxPersonajes.Name = "listaPersonajes";
            listBoxPersonajes.Size = new Size(575, 463);
            listBoxPersonajes.TabIndex = 8;
            // 
            // buttonMostrarDatos
            // 
            buttonMostrarDatos.Location = new Point(219, 537);
            buttonMostrarDatos.Name = "buttonMostrarDatos";
            buttonMostrarDatos.Size = new Size(162, 34);
            buttonMostrarDatos.TabIndex = 12;
            buttonMostrarDatos.Text = "Mostrar Informacion";
            buttonMostrarDatos.UseVisualStyleBackColor = true;
            buttonMostrarDatos.Click += buttonMostrarDatos_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 608);
            Controls.Add(buttonMostrarDatos);
            Controls.Add(listBoxPersonajes);
            Controls.Add(buttonModificar);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(buttonEliminar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Formulario1";
            Text = "Formulario1";
            Load += Formulario1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button buttonEliminar;
        private Button buttonModificar;
        private MenuStrip menuStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem agregarPersonajeToolStripMenuItem;
        private ToolStripMenuItem magoToolStripMenuItem;
        private ToolStripMenuItem arqueroToolStripMenuItem;
        private ToolStripMenuItem tanqueToolStripMenuItem;
        private ToolStripMenuItem guardarPersonajesToolStripMenuItem;
        private ListBox listBoxPersonajes;
        private Button buttonMostrarDatos;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
    }
}