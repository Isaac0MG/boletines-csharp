namespace Boletin_Tema4
{
    partial class Ejercicio6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio6));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panelNavegacionImagenes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.panelNavegacionImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbrir.Location = new System.Drawing.Point(12, 375);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(115, 38);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // panelImagenes
            // 
            this.panelImagenes.AutoScroll = true;
            this.panelImagenes.Location = new System.Drawing.Point(12, 12);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(256, 336);
            this.panelImagenes.TabIndex = 2;
            // 
            // pcbImagen
            // 
            this.pcbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImagen.Location = new System.Drawing.Point(299, 12);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(330, 336);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 3;
            this.pcbImagen.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnterior.Location = new System.Drawing.Point(3, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(38, 35);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.anteriorImagen);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSiguiente.Location = new System.Drawing.Point(47, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(38, 35);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.siguienteImagen);
            // 
            // panelNavegacionImagenes
            // 
            this.panelNavegacionImagenes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelNavegacionImagenes.Controls.Add(this.btnAnterior);
            this.panelNavegacionImagenes.Controls.Add(this.btnSiguiente);
            this.panelNavegacionImagenes.Location = new System.Drawing.Point(541, 370);
            this.panelNavegacionImagenes.Name = "panelNavegacionImagenes";
            this.panelNavegacionImagenes.Size = new System.Drawing.Size(88, 43);
            this.panelNavegacionImagenes.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(133, 375);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 1;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjustes.Location = new System.Drawing.Point(653, 12);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(44, 44);
            this.btnAjustes.TabIndex = 7;
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.panelNavegacionImagenes);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.btnAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio6_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ejercicio6_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.panelNavegacionImagenes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.FlowLayoutPanel panelNavegacionImagenes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}