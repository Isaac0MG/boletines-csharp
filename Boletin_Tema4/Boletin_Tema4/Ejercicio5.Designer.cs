namespace Boletin_Tema4
{
    partial class Ejercicio5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio5));
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.timerBroma = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarNúmeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(180, 99);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.ReadOnly = true;
            this.txtUsuario1.Size = new System.Drawing.Size(201, 20);
            this.txtUsuario1.TabIndex = 100;
            // 
            // timerBroma
            // 
            this.timerBroma.Interval = 10000;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(387, 91);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 101;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStripOpciones
            // 
            this.menuStripOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStripOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuStripOpciones.Name = "menuStripOpciones";
            this.menuStripOpciones.Size = new System.Drawing.Size(584, 24);
            this.menuStripOpciones.TabIndex = 102;
            this.menuStripOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarNúmeroToolStripMenuItem,
            this.mostrarAgendaToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // grabarNúmeroToolStripMenuItem
            // 
            this.grabarNúmeroToolStripMenuItem.Name = "grabarNúmeroToolStripMenuItem";
            this.grabarNúmeroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grabarNúmeroToolStripMenuItem.Text = "Grabar número";
            this.grabarNúmeroToolStripMenuItem.Click += new System.EventHandler(this.grabarNúmeroToolStripMenuItem_Click);
            // 
            // mostrarAgendaToolStripMenuItem
            // 
            this.mostrarAgendaToolStripMenuItem.Name = "mostrarAgendaToolStripMenuItem";
            this.mostrarAgendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarAgendaToolStripMenuItem.Text = "Mostrar agenda";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.menuStripOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOpciones;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 5";
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.Timer timerBroma;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarNúmeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}