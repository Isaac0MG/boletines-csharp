namespace Boletin_Tema4
{
    partial class VerNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerNumeros));
            this.txtMostrarNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMostrarNumeros
            // 
            this.txtMostrarNumeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMostrarNumeros.Location = new System.Drawing.Point(0, 0);
            this.txtMostrarNumeros.Multiline = true;
            this.txtMostrarNumeros.Name = "txtMostrarNumeros";
            this.txtMostrarNumeros.ReadOnly = true;
            this.txtMostrarNumeros.Size = new System.Drawing.Size(584, 361);
            this.txtMostrarNumeros.TabIndex = 0;
            // 
            // VerNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtMostrarNumeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrarNumeros;
    }
}