namespace Boletin1
{
    partial class Pachinko
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
            this.LadoIzquierdo = new System.Windows.Forms.Panel();
            this.LadoDerecho = new System.Windows.Forms.Panel();
            this.Pantalla = new System.Windows.Forms.Panel();
            this.Botones = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LadoIzquierdo
            // 
            this.LadoIzquierdo.BackColor = System.Drawing.Color.Red;
            this.LadoIzquierdo.Location = new System.Drawing.Point(0, 1);
            this.LadoIzquierdo.Name = "LadoIzquierdo";
            this.LadoIzquierdo.Size = new System.Drawing.Size(241, 660);
            this.LadoIzquierdo.TabIndex = 0;
            // 
            // LadoDerecho
            // 
            this.LadoDerecho.BackColor = System.Drawing.Color.Red;
            this.LadoDerecho.Location = new System.Drawing.Point(746, 1);
            this.LadoDerecho.Name = "LadoDerecho";
            this.LadoDerecho.Size = new System.Drawing.Size(243, 660);
            this.LadoDerecho.TabIndex = 1;
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.Gold;
            this.Pantalla.Location = new System.Drawing.Point(240, 1);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(507, 400);
            this.Pantalla.TabIndex = 1;
            // 
            // Botones
            // 
            this.Botones.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Botones.Location = new System.Drawing.Point(240, 397);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(510, 261);
            this.Botones.TabIndex = 2;
            // 
            // Pachinko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.LadoDerecho);
            this.Controls.Add(this.LadoIzquierdo);
            this.Name = "Pachinko";
            this.Text = "Pachinko";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LadoIzquierdo;
        private System.Windows.Forms.Panel LadoDerecho;
        private System.Windows.Forms.Panel Pantalla;
        private System.Windows.Forms.Panel Botones;
    }
}