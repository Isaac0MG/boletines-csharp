namespace Boletin_Tema4
{
    partial class Ejercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3));
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.chkAbrirModal = new System.Windows.Forms.CheckBox();
            this.tmrContador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(193, 12);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(186, 43);
            this.btnCargarImagen.TabIndex = 0;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // chkAbrirModal
            // 
            this.chkAbrirModal.AutoSize = true;
            this.chkAbrirModal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbrirModal.Location = new System.Drawing.Point(393, 21);
            this.chkAbrirModal.Name = "chkAbrirModal";
            this.chkAbrirModal.Size = new System.Drawing.Size(81, 26);
            this.chkAbrirModal.TabIndex = 1;
            this.chkAbrirModal.Text = "Modal";
            this.chkAbrirModal.UseVisualStyleBackColor = true;
            this.chkAbrirModal.CheckedChanged += new System.EventHandler(this.chkAbrirModal_CheckedChanged);
            // 
            // tmrContador
            // 
            this.tmrContador.Enabled = true;
            this.tmrContador.Interval = 1000;
            this.tmrContador.Tick += new System.EventHandler(this.tmrContador_Tick);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.chkAbrirModal);
            this.Controls.Add(this.btnCargarImagen);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.CheckBox chkAbrirModal;
        private System.Windows.Forms.Timer tmrContador;
    }
}