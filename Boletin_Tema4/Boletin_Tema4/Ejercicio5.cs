using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio5 : Form
    {
        private const int CoordenadaX = 215;
        private const int CoordenadaY = 157;
        private const int AumentarX = 46;
        private const int AumentarY = 46;
        private Color colorAlPresionar = Color.Red;
        private Color colorAlEntrar = Color.LightBlue;
        private Color colorPorDefecto = SystemColors.Control;
        private List<string> simbolosTeclado;

        public Ejercicio5()
        {
            InitializeComponent();

            this.KeyPreview = true;

            //Random rnd = new Random();

            //timerBroma.Tick += (sender, e) =>
            //{
            //    // Obtiene el ancho y alto de la pantalla actual
            //    int maxX = Screen.PrimaryScreen.Bounds.Width;
            //    int maxY = Screen.PrimaryScreen.Bounds.Height;

            //    // Teletransporta el cursor a coordenadas totalmente aleatorias del monitor
            //    Cursor.Position = new Point(rnd.Next(100, maxX - 100), rnd.Next(100, maxY - 100));
            //};

            simbolosTeclado = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };

            int x = CoordenadaX;
            int y = CoordenadaY;

            for (int i = 1; i < simbolosTeclado.Count + 1; i++)
            {
                Button btn = new Button();
                btn.Text = simbolosTeclado[i - 1];
                btn.SetBounds(x, y, 40, 40);
                btn.TabIndex = i;
                btn.Click += (sender, e) =>
                {
                    txtUsuario1.Text += btn.Text;
                    btn.BackColor = colorAlPresionar;
                };
                btn.MouseEnter += (sender, e) =>
                {
                    btn.BackColor = colorAlEntrar;
                };
                btn.MouseLeave += (sender, e) =>
                {
                    if (btn.BackColor != colorAlPresionar)
                        btn.BackColor = colorPorDefecto;
                };
                btn.BackColor = SystemColors.Control;
                this.Controls.Add(btn);

                x += AumentarX;

                if (i % 3 == 0)
                {
                    x = CoordenadaX;
                    y += AumentarY;
                }
            }

            this.KeyPress += (sender, e) =>
            {
                string tecla = e.KeyChar.ToString();

                if (simbolosTeclado.Contains(tecla))
                {
                    txtUsuario1.Text += tecla;
                }
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsuario1.Text = "";

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.BackColor = colorPorDefecto;
                }
            }
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrabarNumero grabarNumero = new GrabarNumero(txtUsuario1.Text);
        }
    }
}
