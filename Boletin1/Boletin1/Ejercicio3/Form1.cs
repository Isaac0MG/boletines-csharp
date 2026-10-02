using Ejercicio3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnTirar.Text = "Tirar x3 | 150";
            btnTirar.Image = new Bitmap(Properties.Resources.carats, 30, 28);
            btnTirar.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            //Properties.Resources.ResourceManager.GetObject("Thunder");

            //string json = File.ReadAllText("caballos.json");

            //DatosCaballos datos = JsonSerializer.Deserialize<DatosCaballos>(json);

            //List<Caballo> caballos = datos.Caballos;
        }
    }
}
