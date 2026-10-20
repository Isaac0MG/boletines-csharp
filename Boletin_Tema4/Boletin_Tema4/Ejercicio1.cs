using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio1 : Form
    {
        private Color colorBoton;
        private int X;
        private int Y;
        private int widthButton;
        private int heightButton;


        public Ejercicio1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.MouseMove += Ejercicio1_MouseMove;
            this.MouseLeave += Ejercicio1_MouseLeave;
            this.MouseDown += Ejercicio1_MouseDown;
            this.MouseUp += Ejercicio1_MouseUp;
            this.KeyDown += Ejercicio1_KeyDown;
            this.FormClosing += Ejercicio1_FormClosing;

            btn1.MouseMove += Ejercicio1_MouseMove;

            btn2.MouseMove += Ejercicio1_MouseMove;

            X = 170;
            Y = 100;
            widthButton = 40;
            heightButton = 40;

            for (int i = 1; i < 21; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                btn.BackColor = SystemColors.Control;
                btn.SetBounds(X, Y, widthButton, heightButton);
                btn.MouseMove += Ejercicio1_MouseMove;
                btn.MouseDown += Ejercicio1_MouseDown;
                btn.MouseUp += Ejercicio1_MouseUp;
                btn.Tag = "botonNumero";
                this.Controls.Add(btn);

                X += 60;

                if (i % 4 == 0)
                {
                    X = 170;
                    Y += 50;
                }
            }
        }

        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender != this)
            {
                if (sender is Button)
                {

                    Button btn = (Button)sender;

                    double x = e.X + btn.Left;
                    double y = e.Y + btn.Top;

                    this.Text = $"X: {x} | Y: {y}";
                }
            }
            else
            {
                this.Text = $"X: {e.X} | Y: {e.Y}";
            }
        }

        private void Ejercicio1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "X: 0 | Y: 0";
        }

        private void Ejercicio1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;

                if (btn.Tag == "botonNumero")
                {
                    btn.ForeColor = Color.Green;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    btn1.BackColor = Color.Green;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    btn2.BackColor = Color.Red;
                }
                else
                {
                    btn1.BackColor = Color.Green;
                    btn2.BackColor = Color.Red;
                }
            }
        }

        private void Ejercicio1_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;

                if (btn.Tag == "botonNumero")
                {
                    btn.ForeColor = Color.Black;
                }
            }
            else
            {

                if (e.Button == MouseButtons.Left)
                {
                    btn1.BackColor = SystemColors.Control;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    btn2.BackColor = SystemColors.Control;
                }
                else
                {
                    btn1.BackColor = SystemColors.Control;
                    btn2.BackColor = SystemColors.Control;
                }
            }
        }

        private void Ejercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Ejercicio 1";
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
        }

        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres salir del formulario?", "Salir del formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
