using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracticaLogin
{
    public partial class CargarNomina : Form
    {
        public CargarNomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal nomina = new Principal();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string a;
            a = txtDireccion.Text;
            ListViewItem listViewItem = new ListViewItem();
            StreamReader sr = new StreamReader(a);
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                listViewItem.SubItems.Add(linea);
            }
            lvNomina.Items.Add(listViewItem);
            sr.Close();
        }
    }
}
