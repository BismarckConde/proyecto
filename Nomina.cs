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
    public partial class Nomina : Form
    {
        double salBas;
        int Ant;
        int HExtr;
        double Cuo;
        double salarioBru;
        double AntS;
        public Nomina()
        {
            InitializeComponent();

            Desactivar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Activar();

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHorasEx.Text))
            {
                HExtr = 0;
            }
            else
            {
                HExtr = Convert.ToInt32(txtHorasEx.Text);
            }
            if (string.IsNullOrEmpty(txtAntSal.Text))
            {
                Ant = 0;
            }
            else
            {
                Ant = Convert.ToInt32(txtAntiguedad.Text);
            }
            if (string.IsNullOrEmpty(txtCuota.Text))
            {
                Cuo = 0;
            }
            else
            {
                Cuo = Convert.ToInt32(txtCuota.Text);
            }
            if (string.IsNullOrEmpty(txtAntSal.Text))
            {
                AntS = 0;
            }
            else
            {
                AntS = Convert.ToDouble(txtAntSal.Text);
            }
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Ingrese el salaerio", "Salario no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {

                salBas = Convert.ToDouble(txtSalario.Text);
                CalculandoSalarioBruto obj = new CalculandoSalarioBruto(salBas, Ant, HExtr, salarioBru);
                CalculandoTotalDeducciones obj2 = new CalculandoTotalDeducciones(salBas, Cuo, AntS);
                ListViewItem listViewItem = new ListViewItem(txtEmpleado.Text);
                listViewItem.SubItems.Add(txtSalario.Text);
                listViewItem.SubItems.Add(obj.CalculandoHoras().ToString());
                listViewItem.SubItems.Add(obj.CalculandoAntiguedad().ToString());
                listViewItem.SubItems.Add(obj.CalculandoSalarioBrut().ToString());
                listViewItem.SubItems.Add(obj2.calculanoInss().ToString());
                listViewItem.SubItems.Add("-");
                listViewItem.SubItems.Add(obj2.calculanoCuota().ToString());
                listViewItem.SubItems.Add(AntS.ToString());
                listViewItem.SubItems.Add(obj2.calculanoTotal().ToString());
                double Ded = obj2.calculanoTotal();
                double SalBru = obj.CalculandoSalarioBrut();
                double salNeto = SalBru - Ded;
                listViewItem.SubItems.Add(salNeto.ToString());
                lvNomina.Items.Add(listViewItem);
                System.IO.StreamWriter ArchivoNomina = new StreamWriter("Nomina.txt", true);
                ArchivoNomina.WriteLine();
                ArchivoNomina.Close();

            }


            Desactivar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }






        //___--_-_-ACTIVANDO Y DESACTIVANDO BOTONES-_-_--___\\
        private void btnActCuo_Click(object sender, EventArgs e)
        {
            if (rdSiCuo.Checked == true)
            {
                txtCuota.Enabled = true;

            }
            else
            {
                txtCuota.Enabled = false;
            }
        }
        private void Desactivar()
        {
            txtAntiguedad.Enabled = false;
            txtCuota.Enabled = false;
            txtHorasEx.Enabled = false;
            txtSalario.Enabled = false;
            rdSiHE.Enabled = false;
            rdNoHE.Enabled = false;
            btnIngresar.Enabled = false;
            btnActCuo.Enabled = false;
            btnActHoras.Enabled = false;
            button1.Enabled = false;
            rdSiCuo.Enabled = false;
            rdSiAntg.Enabled = false;
            rdNoAntg.Enabled = false;
            rdSiHE.Enabled = false;
            rdNoHE.Enabled = false;
            rdNoCuo.Enabled = false;
            btnAgregar.Enabled = true;
            txtAntSal.Enabled = false;
            txtEmpleado.Enabled = false;
            rdAntSalNo.Enabled = false;
            rdAntSalSi.Enabled = false;
            btnActAntSal.Enabled = false;
        }
        private void btnActHoras_Click(object sender, EventArgs e)
        {
            if (rdSiHE.Checked == true)
            {
                txtHorasEx.Enabled = true;

            }
            else
            {
                txtHorasEx.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdSiAntg.Checked == true)
            {
                txtAntiguedad.Enabled = true;

            }
            else
            {
                txtAntiguedad.Enabled = false;
            }
        }
        private void Activar()
        {
            txtSalario.Enabled = true;
            btnActCuo.Enabled = true;
            btnActHoras.Enabled = true;
            button1.Enabled = true;
            rdSiHE.Enabled = true;
            rdNoHE.Enabled = true;
            rdNoCuo.Enabled = true;
            rdSiCuo.Enabled = true;
            rdSiAntg.Enabled = true;
            rdNoAntg.Enabled = true;
            txtEmpleado.Enabled = true;
            btnActAntSal.Enabled = true;
            rdAntSalSi.Enabled = true;
            rdAntSalNo.Enabled = true;
            btnAgregar.Enabled = false;
            btnIngresar.Enabled = true;
        }

        private void btnActAntSal_Click(object sender, EventArgs e)
        {
            if (rdAntSalSi.Checked == true)
            {
                txtAntSal.Enabled = true;

            }
            else
            {
                txtAntSal.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal nomina = new Principal();
            this.Hide();
            nomina.ShowDialog();
            this.Close();
        }


    }
}
