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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            arqueraToolStripMenuItem = new ToolStripMenuItem();
            tanqueToolStripMenuItem = new ToolStripMenuItem();
            mAgoToolStripMenuItem = new ToolStripMenuItem();
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
            // button1
            // 
            button1.Location = new Point(284, 417);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 0;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 417);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 7;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(380, 349);
            listBox1.TabIndex = 8;
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
            menuStrip1.BackColor = SystemColors.Control;
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
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mAgoToolStripMenuItem, tanqueToolStripMenuItem, arqueraToolStripMenuItem });
            agregarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(70, 23);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // arqueraToolStripMenuItem
            // 
            arqueraToolStripMenuItem.Name = "arqueraToolStripMenuItem";
            arqueraToolStripMenuItem.Size = new Size(180, 22);
            arqueraToolStripMenuItem.Text = "Arquera";
            // 
            // tanqueToolStripMenuItem
            // 
            tanqueToolStripMenuItem.Name = "tanqueToolStripMenuItem";
            tanqueToolStripMenuItem.Size = new Size(180, 22);
            tanqueToolStripMenuItem.Text = "Tanque";
            // 
            // mAgoToolStripMenuItem
            // 
            mAgoToolStripMenuItem.Name = "mAgoToolStripMenuItem";
            mAgoToolStripMenuItem.Size = new Size(180, 24);
            mAgoToolStripMenuItem.Text = "Mago";
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 488);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem mAgoToolStripMenuItem;
        private ToolStripMenuItem tanqueToolStripMenuItem;
        private ToolStripMenuItem arqueraToolStripMenuItem;
    }
}