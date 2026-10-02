namespace Boletin1
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(231, 74);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(170, 46);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Boletín -";
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitulo2.Location = new System.Drawing.Point(395, 74);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(148, 46);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Tema 1";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(296, 169);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(192, 26);
            this.lblOpcion.TabIndex = 2;
            this.lblOpcion.Text = "Escoja un ejercicio:";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Items.AddRange(new object[] {
            "Ejercicio 1 - Suma",
            "Ejercicio 2 - Leer datos",
            "Ejercicio 3 - Pachinko",
            "Ejercicio 4 - Switch",
            "Ejercicio 5 - Funciones",
            "Ejercicio 6 - Título"});
            this.cmbEjercicio.Location = new System.Drawing.Point(301, 216);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(187, 21);
            this.cmbEjercicio.TabIndex = 3;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmbEjercicio);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cmbEjercicio;
    }
}

