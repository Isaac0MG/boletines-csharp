namespace Boletin1
{
    partial class Captcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captcha));
            this.btnSoyUnRobot = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbGreenTick = new System.Windows.Forms.PictureBox();
            this.pcbIA = new System.Windows.Forms.PictureBox();
            this.pcbIADETECTED = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGreenTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIADETECTED)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoyUnRobot
            // 
            this.btnSoyUnRobot.BackColor = System.Drawing.Color.White;
            this.btnSoyUnRobot.Location = new System.Drawing.Point(12, 39);
            this.btnSoyUnRobot.Name = "btnSoyUnRobot";
            this.btnSoyUnRobot.Size = new System.Drawing.Size(79, 72);
            this.btnSoyUnRobot.TabIndex = 0;
            this.btnSoyUnRobot.UseVisualStyleBackColor = false;
            this.btnSoyUnRobot.Click += new System.EventHandler(this.btnSoyUnRobot_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(97, 60);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(119, 26);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "I\'m a robot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pcbGreenTick
            // 
            this.pcbGreenTick.Image = ((System.Drawing.Image)(resources.GetObject("pcbGreenTick.Image")));
            this.pcbGreenTick.Location = new System.Drawing.Point(18, 44);
            this.pcbGreenTick.Name = "pcbGreenTick";
            this.pcbGreenTick.Size = new System.Drawing.Size(67, 61);
            this.pcbGreenTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGreenTick.TabIndex = 3;
            this.pcbGreenTick.TabStop = false;
            this.pcbGreenTick.Visible = false;
            // 
            // pcbIA
            // 
            this.pcbIA.Image = ((System.Drawing.Image)(resources.GetObject("pcbIA.Image")));
            this.pcbIA.Location = new System.Drawing.Point(277, 12);
            this.pcbIA.Name = "pcbIA";
            this.pcbIA.Size = new System.Drawing.Size(120, 129);
            this.pcbIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIA.TabIndex = 4;
            this.pcbIA.TabStop = false;
            this.pcbIA.Visible = false;
            // 
            // pcbIADETECTED
            // 
            this.pcbIADETECTED.Image = ((System.Drawing.Image)(resources.GetObject("pcbIADETECTED.Image")));
            this.pcbIADETECTED.Location = new System.Drawing.Point(18, 44);
            this.pcbIADETECTED.Name = "pcbIADETECTED";
            this.pcbIADETECTED.Size = new System.Drawing.Size(67, 61);
            this.pcbIADETECTED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIADETECTED.TabIndex = 5;
            this.pcbIADETECTED.TabStop = false;
            this.pcbIADETECTED.Visible = false;
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 153);
            this.Controls.Add(this.pcbIADETECTED);
            this.Controls.Add(this.pcbIA);
            this.Controls.Add(this.pcbGreenTick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnSoyUnRobot);
            this.MaximizeBox = false;
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGreenTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIADETECTED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoyUnRobot;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbGreenTick;
        private System.Windows.Forms.PictureBox pcbIA;
        private System.Windows.Forms.PictureBox pcbIADETECTED;
    }
}