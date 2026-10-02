using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Boletin1
{
    public partial class Captcha : Form
    {
        public DialogResult resultadoCaptcha;

        public Captcha()
        {
            InitializeComponent();
        }

        private async void btnSoyUnRobot_Click(object sender, EventArgs e)
        {

            resultadoCaptcha = MessageBox.Show("Estás seguro de que eres un robot?", "IA Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultadoCaptcha == System.Windows.Forms.DialogResult.No)
            {
                pcbGreenTick.Visible = true;
                await Task.Delay(1000);
                this.Close();
            }
            else
            {
                pcbIADETECTED.Visible = true;
                pcbIA.Visible = true;
                this.BackColor = Color.Red;
                lblTexto.Text = "IA DETECTED!!";
                await Task.Delay(2000);
                lblTexto.Text = "CERRANDO APP!";
                await Task.Delay(2000);
                Application.Exit();
            }
        }
    }
}
