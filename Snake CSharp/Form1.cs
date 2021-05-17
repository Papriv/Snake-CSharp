using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_CSharp
{
    public partial class Form1 : Form
    {

        Juego oJuego;
        public Form1()
        {
            InitializeComponent();

            oJuego = new Juego(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oJuego.Mostrar();
        }
    }
}
