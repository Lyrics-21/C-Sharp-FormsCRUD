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
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            ascendenteToolStripMenuItem = new ToolStripMenuItem();
            nivelToolStripMenuItem = new ToolStripMenuItem();
            dañoToolStripMenuItem = new ToolStripMenuItem();
            descendenteToolStripMenuItem = new ToolStripMenuItem();
            nivelToolStripMenuItem1 = new ToolStripMenuItem();
            dañoToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosLogeadosToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            listBoxPersonajes = new ListBox();
            buttonMostrarDatos = new Button();
            abrirToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, ordenarToolStripMenuItem, usuariosLogeadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(599, 27);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = SystemColors.ControlDark;
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPersonajeToolStripMenuItem, guardarPersonajesToolStripMenuItem, guardarComoToolStripMenuItem, abrirToolStripMenuItem });
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
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click_1;
            // 
            // ordenarToolStripMenuItem
            // 
            ordenarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem, descendenteToolStripMenuItem });
            ordenarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            ordenarToolStripMenuItem.Size = new Size(72, 23);
            ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // ascendenteToolStripMenuItem
            // 
            ascendenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nivelToolStripMenuItem, dañoToolStripMenuItem });
            ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            ascendenteToolStripMenuItem.Size = new Size(157, 24);
            ascendenteToolStripMenuItem.Text = "Ascendente";
            // 
            // nivelToolStripMenuItem
            // 
            nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            nivelToolStripMenuItem.Size = new Size(111, 24);
            nivelToolStripMenuItem.Text = "Nivel";
            nivelToolStripMenuItem.Click += nivelToolStripMenuItem_Click;
            // 
            // dañoToolStripMenuItem
            // 
            dañoToolStripMenuItem.Name = "dañoToolStripMenuItem";
            dañoToolStripMenuItem.Size = new Size(111, 24);
            dañoToolStripMenuItem.Text = "Daño";
            dañoToolStripMenuItem.Click += dañoToolStripMenuItem_Click;
            // 
            // descendenteToolStripMenuItem
            // 
            descendenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nivelToolStripMenuItem1, dañoToolStripMenuItem1 });
            descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            descendenteToolStripMenuItem.Size = new Size(157, 24);
            descendenteToolStripMenuItem.Text = "Descendente";
            // 
            // nivelToolStripMenuItem1
            // 
            nivelToolStripMenuItem1.Name = "nivelToolStripMenuItem1";
            nivelToolStripMenuItem1.Size = new Size(111, 24);
            nivelToolStripMenuItem1.Text = "Nivel";
            nivelToolStripMenuItem1.Click += nivelToolStripMenuItem1_Click;
            // 
            // dañoToolStripMenuItem1
            // 
            dañoToolStripMenuItem1.Name = "dañoToolStripMenuItem1";
            dañoToolStripMenuItem1.Size = new Size(111, 24);
            dañoToolStripMenuItem1.Text = "Daño";
            dañoToolStripMenuItem1.Click += dañoToolStripMenuItem1_Click;
            // 
            // usuariosLogeadosToolStripMenuItem
            // 
            usuariosLogeadosToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usuariosLogeadosToolStripMenuItem.Name = "usuariosLogeadosToolStripMenuItem";
            usuariosLogeadosToolStripMenuItem.Size = new Size(133, 23);
            usuariosLogeadosToolStripMenuItem.Text = "Usuarios logeados";
            usuariosLogeadosToolStripMenuItem.Click += usuariosLogeadosToolStripMenuItem_Click;
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
            // listBoxPersonajes
            // 
            listBoxPersonajes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPersonajes.FormattingEnabled = true;
            listBoxPersonajes.ItemHeight = 17;
            listBoxPersonajes.Location = new Point(12, 56);
            listBoxPersonajes.Name = "listBoxPersonajes";
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
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(189, 24);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
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
            Text = "Personaje";
            FormClosing += Formulario1_FormClosing;
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
        private ToolStripMenuItem usuariosLogeadosToolStripMenuItem;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem ascendenteToolStripMenuItem;
        private ToolStripMenuItem descendenteToolStripMenuItem;
        private ToolStripMenuItem nivelToolStripMenuItem;
        private ToolStripMenuItem nivelToolStripMenuItem1;
        private ToolStripMenuItem dañoToolStripMenuItem;
        private ToolStripMenuItem dañoToolStripMenuItem1;
        private ToolStripMenuItem abrirToolStripMenuItem;
    }
}