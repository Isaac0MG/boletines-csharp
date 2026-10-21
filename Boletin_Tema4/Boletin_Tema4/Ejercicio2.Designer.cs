namespace Boletin_Tema4
{
    partial class Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.lblAzul = new System.Windows.Forms.Label();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(485, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            this.btnSalir.MouseEnter += new System.EventHandler(this.entrarBoton);
            this.btnSalir.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // txtRojo
            // 
            this.txtRojo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRojo.Location = new System.Drawing.Point(59, 53);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(53, 28);
            this.txtRojo.TabIndex = 1;
            this.txtRojo.Tag = "color";
            this.txtRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRojo.Enter += new System.EventHandler(this.cambiarFocoColor);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.Location = new System.Drawing.Point(29, 53);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(27, 28);
            this.lblRojo.TabIndex = 4;
            this.lblRojo.Text = "R";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.Location = new System.Drawing.Point(129, 53);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(28, 28);
            this.lblVerde.TabIndex = 6;
            this.lblVerde.Text = "G";
            // 
            // txtVerde
            // 
            this.txtVerde.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerde.Location = new System.Drawing.Point(159, 53);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(53, 28);
            this.txtVerde.TabIndex = 2;
            this.txtVerde.Tag = "color";
            this.txtVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVerde.Enter += new System.EventHandler(this.cambiarFocoColor);
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzul.Location = new System.Drawing.Point(232, 53);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(26, 28);
            this.lblAzul.TabIndex = 8;
            this.lblAzul.Text = "B";
            // 
            // txtAzul
            // 
            this.txtAzul.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAzul.Location = new System.Drawing.Point(262, 53);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(53, 28);
            this.txtAzul.TabIndex = 3;
            this.txtAzul.Tag = "color";
            this.txtAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAzul.Enter += new System.EventHandler(this.cambiarFocoColor);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(342, 53);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(69, 28);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.entrarBoton);
            this.btnColor.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Red;
            this.lblInformacion.Location = new System.Drawing.Point(30, 104);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 19);
            this.lblInformacion.TabIndex = 10;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Location = new System.Drawing.Point(137, 157);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(352, 20);
            this.txtRutaImagen.TabIndex = 5;
            this.txtRutaImagen.Tag = "image";
            this.txtRutaImagen.Enter += new System.EventHandler(this.txtRutaImagen_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ruta imagen:";
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(194, 189);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(160, 160);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 13;
            this.pcbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(360, 189);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(129, 29);
            this.btnCargarImagen.TabIndex = 6;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            this.btnCargarImagen.MouseEnter += new System.EventHandler(this.entrarBoton);
            this.btnCargarImagen.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(485, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 34);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.entrarBoton);
            this.btnReset.MouseLeave += new System.EventHandler(this.salirBoton);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnReset;
    }
}