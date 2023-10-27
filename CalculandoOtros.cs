using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoOtros : ICalculandoOtros
    {
        public double salBas { get ; set ; }
        public double InssPatronal { get ; set ; }
        public double Inatec { get ; set; }
        public double Vacacciones { get; set ; }
        public CalculandoOtros(double sal) 
        {
            salBas = sal;
        }

        public double CalculandoInatec()
        {
            Inatec = salBas*0.02;
            return Inatec;
        }

        public double CalculandoInssPatronal()
        {
            InssPatronal=salBas*0.225;
            return InssPatronal;
        }

        public double CalculandoVacacciones()
        {
            Vacacciones = salBas / 30;
            Vacacciones = Vacacciones * 2.5;
            return Vacacciones;
        }
    }
}
