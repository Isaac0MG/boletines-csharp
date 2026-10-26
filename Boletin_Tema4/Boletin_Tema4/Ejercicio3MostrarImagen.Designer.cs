namespace Boletin_Tema4
{
    partial class Ejercicio3MostrarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3MostrarImagen));
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.cmsFormatoTamañoImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.strechImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.cmsFormatoTamañoImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImagen
            // 
            this.pcbImagen.ContextMenuStrip = this.cmsFormatoTamañoImagen;
            this.pcbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImagen.Location = new System.Drawing.Point(0, 0);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(784, 461);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 0;
            this.pcbImagen.TabStop = false;
            // 
            // cmsFormatoTamañoImagen
            // 
            this.cmsFormatoTamañoImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strechImageToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.cmsFormatoTamañoImagen.Name = "cmsFormatoTamañoImagen";
            this.cmsFormatoTamañoImagen.Size = new System.Drawing.Size(141, 48);
            // 
            // strechImageToolStripMenuItem
            // 
            this.strechImageToolStripMenuItem.Name = "strechImageToolStripMenuItem";
            this.strechImageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.strechImageToolStripMenuItem.Text = "StrechImage";
            this.strechImageToolStripMenuItem.Click += new System.EventHandler(this.strechImageToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // Ejercicio3MostrarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pcbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio3MostrarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3MostrarImagen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3MostrarImagen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.cmsFormatoTamañoImagen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.ContextMenuStrip cmsFormatoTamañoImagen;
        private System.Windows.Forms.ToolStripMenuItem strechImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
    }
}