namespace Boletin_Tema4
{
    partial class Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(156, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "btn1";
            this.btn1.Text = "Botón 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ejercicio1_MouseMove);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(307, 30);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "btn2";
            this.btn2.Text = "Botón 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ejercicio1_MouseMove);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ejercicio1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ejercicio1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Ejercicio1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ejercicio1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ejercicio1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}