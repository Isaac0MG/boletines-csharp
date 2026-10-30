namespace Boletin_Tema4
{
    partial class Ejercicio4_1
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
            this.lblIndicesSeleccionadosLista1 = new System.Windows.Forms.Label();
            this.lblCantidadElementosLista1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbTraspasarLista1 = new System.Windows.Forms.RadioButton();
            this.rdbTraspasarLista2 = new System.Windows.Forms.RadioButton();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.rdbEliminarLista1 = new System.Windows.Forms.RadioButton();
            this.rdbEliminarLista2 = new System.Windows.Forms.RadioButton();
            this.txtTextoAñadir = new System.Windows.Forms.TextBox();
            this.lblLista2 = new System.Windows.Forms.Label();
            this.lblLista1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lstCaja2 = new System.Windows.Forms.ListBox();
            this.lstCaja1 = new System.Windows.Forms.ListBox();
            this.tmrHeader = new System.Windows.Forms.Timer(this.components);
            this.toolTipGenerico = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndicesSeleccionadosLista1
            // 
            this.lblIndicesSeleccionadosLista1.AutoSize = true;
            this.lblIndicesSeleccionadosLista1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicesSeleccionadosLista1.Location = new System.Drawing.Point(298, 79);
            this.lblIndicesSeleccionadosLista1.Name = "lblIndicesSeleccionadosLista1";
            this.lblIndicesSeleccionadosLista1.Size = new System.Drawing.Size(0, 20);
            this.lblIndicesSeleccionadosLista1.TabIndex = 35;
            // 
            // lblCantidadElementosLista1
            // 
            this.lblCantidadElementosLista1.AutoSize = true;
            this.lblCantidadElementosLista1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadElementosLista1.Location = new System.Drawing.Point(299, 23);
            this.lblCantidadElementosLista1.Name = "lblCantidadElementosLista1";
            this.lblCantidadElementosLista1.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadElementosLista1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbTraspasarLista1);
            this.panel1.Controls.Add(this.rdbTraspasarLista2);
            this.panel1.Location = new System.Drawing.Point(518, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 75);
            this.panel1.TabIndex = 31;
            // 
            // rdbTraspasarLista1
            // 
            this.rdbTraspasarLista1.AutoSize = true;
            this.rdbTraspasarLista1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraspasarLista1.Location = new System.Drawing.Point(65, 46);
            this.rdbTraspasarLista1.Name = "rdbTraspasarLista1";
            this.rdbTraspasarLista1.Size = new System.Drawing.Size(74, 23);
            this.rdbTraspasarLista1.TabIndex = 13;
            this.rdbTraspasarLista1.TabStop = true;
            this.rdbTraspasarLista1.Text = "Lista 2";
            this.rdbTraspasarLista1.UseVisualStyleBackColor = true;
            this.rdbTraspasarLista1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbTraspasarLista2
            // 
            this.rdbTraspasarLista2.AutoSize = true;
            this.rdbTraspasarLista2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraspasarLista2.Location = new System.Drawing.Point(65, 15);
            this.rdbTraspasarLista2.Name = "rdbTraspasarLista2";
            this.rdbTraspasarLista2.Size = new System.Drawing.Size(74, 23);
            this.rdbTraspasarLista2.TabIndex = 12;
            this.rdbTraspasarLista2.TabStop = true;
            this.rdbTraspasarLista2.Text = "Lista 1";
            this.rdbTraspasarLista2.UseVisualStyleBackColor = true;
            this.rdbTraspasarLista2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.rdbEliminarLista1);
            this.panelEliminar.Controls.Add(this.rdbEliminarLista2);
            this.panelEliminar.Location = new System.Drawing.Point(303, 352);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(200, 75);
            this.panelEliminar.TabIndex = 29;
            // 
            // rdbEliminarLista1
            // 
            this.rdbEliminarLista1.AutoSize = true;
            this.rdbEliminarLista1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEliminarLista1.Location = new System.Drawing.Point(66, 15);
            this.rdbEliminarLista1.Name = "rdbEliminarLista1";
            this.rdbEliminarLista1.Size = new System.Drawing.Size(74, 23);
            this.rdbEliminarLista1.TabIndex = 6;
            this.rdbEliminarLista1.TabStop = true;
            this.rdbEliminarLista1.Text = "Lista 1";
            this.rdbEliminarLista1.UseVisualStyleBackColor = true;
            this.rdbEliminarLista1.CheckedChanged += new System.EventHandler(this.rdbEliminarLista1_CheckedChanged);
            // 
            // rdbEliminarLista2
            // 
            this.rdbEliminarLista2.AutoSize = true;
            this.rdbEliminarLista2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEliminarLista2.Location = new System.Drawing.Point(66, 46);
            this.rdbEliminarLista2.Name = "rdbEliminarLista2";
            this.rdbEliminarLista2.Size = new System.Drawing.Size(74, 23);
            this.rdbEliminarLista2.TabIndex = 7;
            this.rdbEliminarLista2.TabStop = true;
            this.rdbEliminarLista2.Text = "Lista 2";
            this.rdbEliminarLista2.UseVisualStyleBackColor = true;
            this.rdbEliminarLista2.CheckedChanged += new System.EventHandler(this.rdbEliminarLista2_CheckedChanged);
            // 
            // txtTextoAñadir
            // 
            this.txtTextoAñadir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoAñadir.Location = new System.Drawing.Point(83, 363);
            this.txtTextoAñadir.Name = "txtTextoAñadir";
            this.txtTextoAñadir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextoAñadir.Size = new System.Drawing.Size(200, 29);
            this.txtTextoAñadir.TabIndex = 27;
            this.txtTextoAñadir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLista2
            // 
            this.lblLista2.AutoSize = true;
            this.lblLista2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista2.Location = new System.Drawing.Point(583, 263);
            this.lblLista2.Name = "lblLista2";
            this.lblLista2.Size = new System.Drawing.Size(63, 22);
            this.lblLista2.TabIndex = 33;
            this.lblLista2.Text = "Lista 2";
            // 
            // lblLista1
            // 
            this.lblLista1.AutoSize = true;
            this.lblLista1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista1.Location = new System.Drawing.Point(149, 263);
            this.lblLista1.Name = "lblLista1";
            this.lblLista1.Size = new System.Drawing.Size(63, 22);
            this.lblLista1.TabIndex = 32;
            this.lblLista1.Text = "Lista 1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(303, 306);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspasar.Location = new System.Drawing.Point(518, 306);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(200, 40);
            this.btnTraspasar.TabIndex = 30;
            this.btnTraspasar.Text = "Traspasar";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(83, 306);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(200, 40);
            this.btnAñadir.TabIndex = 26;
            this.btnAñadir.Text = "Añadir a la lista 1";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lstCaja2
            // 
            this.lstCaja2.FormattingEnabled = true;
            this.lstCaja2.Location = new System.Drawing.Point(518, 23);
            this.lstCaja2.Name = "lstCaja2";
            this.lstCaja2.Size = new System.Drawing.Size(200, 238);
            this.lstCaja2.TabIndex = 25;
            // 
            // lstCaja1
            // 
            this.lstCaja1.FormattingEnabled = true;
            this.lstCaja1.Location = new System.Drawing.Point(83, 23);
            this.lstCaja1.Name = "lstCaja1";
            this.lstCaja1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCaja1.Size = new System.Drawing.Size(200, 238);
            this.lstCaja1.TabIndex = 24;
            this.lstCaja1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCaja1_MouseClick);
            // 
            // tmrHeader
            // 
            this.tmrHeader.Enabled = true;
            this.tmrHeader.Interval = 200;
            this.tmrHeader.Tick += new System.EventHandler(this.tmrHeader_Tick);
            // 
            // Ejercicio4_1
            // 
            this.AcceptButton = this.btnAñadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.lblIndicesSeleccionadosLista1);
            this.Controls.Add(this.lblCantidadElementosLista1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEliminar);
            this.Controls.Add(this.txtTextoAñadir);
            this.Controls.Add(this.lblLista2);
            this.Controls.Add(this.lblLista1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lstCaja2);
            this.Controls.Add(this.lstCaja1);
            this.MinimizeBox = false;
            this.Name = "Ejercicio4_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicesSeleccionadosLista1;
        private System.Windows.Forms.Label lblCantidadElementosLista1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTraspasarLista1;
        private System.Windows.Forms.RadioButton rdbTraspasarLista2;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.RadioButton rdbEliminarLista1;
        private System.Windows.Forms.RadioButton rdbEliminarLista2;
        private System.Windows.Forms.TextBox txtTextoAñadir;
        private System.Windows.Forms.Label lblLista2;
        private System.Windows.Forms.Label lblLista1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListBox lstCaja2;
        private System.Windows.Forms.ListBox lstCaja1;
        private System.Windows.Forms.Timer tmrHeader;
        private System.Windows.Forms.ToolTip toolTipGenerico;
    }
}