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
            listaPersonajes = new ListBox();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            mAgoToolStripMenuItem = new ToolStripMenuItem();
            tanqueToolStripMenuItem = new ToolStripMenuItem();
            arqueraToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            buttonEliminar.Location = new Point(238, 417);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(154, 34);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(12, 417);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(154, 34);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // listaPersonajes
            // 
            listaPersonajes.FormattingEnabled = true;
            listaPersonajes.ItemHeight = 15;
            listaPersonajes.Location = new Point(12, 56);
            listaPersonajes.Name = "listaPersonajes";
            listaPersonajes.Size = new Size(380, 349);
            listaPersonajes.TabIndex = 8;
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
            statusStrip1.Location = new Point(0, 466);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(404, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(404, 27);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = SystemColors.ControlDark;
            agregarToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mAgoToolStripMenuItem, tanqueToolStripMenuItem, arqueraToolStripMenuItem, guardarToolStripMenuItem });
            agregarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(70, 23);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // mAgoToolStripMenuItem
            // 
            mAgoToolStripMenuItem.Name = "mAgoToolStripMenuItem";
            mAgoToolStripMenuItem.Size = new Size(128, 24);
            mAgoToolStripMenuItem.Text = "Mago";
            mAgoToolStripMenuItem.Click += mAgoToolStripMenuItem_Click;
            // 
            // tanqueToolStripMenuItem
            // 
            tanqueToolStripMenuItem.Name = "tanqueToolStripMenuItem";
            tanqueToolStripMenuItem.Size = new Size(128, 24);
            tanqueToolStripMenuItem.Text = "Tanque";
            tanqueToolStripMenuItem.Click += tanqueToolStripMenuItem_Click;
            // 
            // arqueraToolStripMenuItem
            // 
            arqueraToolStripMenuItem.Name = "arqueraToolStripMenuItem";
            arqueraToolStripMenuItem.Size = new Size(128, 24);
            arqueraToolStripMenuItem.Text = "Arquera";
            arqueraToolStripMenuItem.Click += arqueraToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(128, 24);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 488);
            Controls.Add(listaPersonajes);
            Controls.Add(buttonModificar);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(buttonEliminar);
            MainMenuStrip = menuStrip1;
            Name = "Formulario1";
            Text = "Formulario1";
            Load += Formulario1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button buttonEliminar;
        private Button buttonModificar;
        private ListBox listaPersonajes;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem mAgoToolStripMenuItem;
        private ToolStripMenuItem tanqueToolStripMenuItem;
        private ToolStripMenuItem arqueraToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
    }
}