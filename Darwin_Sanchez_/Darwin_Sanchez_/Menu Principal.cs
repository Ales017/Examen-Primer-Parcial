using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darwin_Sanchez_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Formulario1button_Click(object sender, EventArgs e)
        {
            Formulario1 formulario = new Formulario1();
            formulario.Show();
        }

        private void Formulario2button_Click(object sender, EventArgs e)
        {
            Formulario2 formulario = new Formulario2();
            formulario.Show();
        }

        private void Formulario3button_Click(object sender, EventArgs e)
        {
            Formulario3 formulario = new Formulario3();
            formulario.Show();
        }
    }
}
