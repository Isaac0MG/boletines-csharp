using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin1
{
    public partial class Ejercicio6 : Form
    {
        int fuenteDefecto = 48;

        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (btnCambiar.Width <= 120)
            {
                DialogResult resultado;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                resultado = MessageBox.Show($"Quieres poner {txtTitulo.Text} como titulo del formulario?", "Cambiar nombre formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    resultado = MessageBox.Show($"Estás completamente seguro de poner {txtTitulo.Text} como titulo del formulario?", "Cambiar nombre formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        Captcha captcha = new Captcha();
                        captcha.ShowDialog();

                        if (captcha.resultadoCaptcha == System.Windows.Forms.DialogResult.No)
                        {
                            MessageBox.Show("Título cambiado correctamente");
                            this.Text = txtTitulo.Text;
                        }
                    }
                    else
                    {
                        btnCambiar.Size = new Size(322, 266);
                        fuenteDefecto = 48;
                        btnCambiar.Font = new Font("Microsoft YaHei UI", 48, FontStyle.Bold);
                        txtTitulo.Text = "";
                    }
                }
                else
                {
                    btnCambiar.Size = new Size(322, 266);
                    fuenteDefecto = 48;
                    btnCambiar.Font = new Font("Microsoft YaHei UI", 48, FontStyle.Bold);
                    txtTitulo.Text = "";
                }
            }
            else
            {
                int disminuirAltura = 20;
                int disminuirAncho = 20;
                int disminuirFuente = 4;

                fuenteDefecto -= disminuirFuente;

                if (fuenteDefecto <= 0)
                {
                    fuenteDefecto = 4;
                }

                btnCambiar.Size = new Size(btnCambiar.Width - disminuirAncho, btnCambiar.Height - disminuirAltura);
                btnCambiar.Font = new Font("Microsoft YaHei UI", fuenteDefecto, FontStyle.Bold);
            }
        }
    }
}
