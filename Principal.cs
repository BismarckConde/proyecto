using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLogin
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nomina nomina = new Nomina();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarNomina nomina = new CargarNomina();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }
    }
}
