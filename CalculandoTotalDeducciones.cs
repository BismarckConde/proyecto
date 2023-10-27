using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoTotalDeducciones : IDeducciones
    {
        public double innsLaboral { get ; set ; }
        public double IR { get ; set  ; }
        public double CuotaSindical { get; set ; }
        public double Anticipo { get; set ; }
        public double Total { get ; set ; }
        public double salBasico { get ; set ; }
        public double Cuo { get; set; }
        public double ir { get; set; }
        public CalculandoTotalDeducciones(double sal,double cuo,double anticipo)
        {
            Cuo = cuo;
            Anticipo = anticipo;
            salBasico = sal;
        }

        public double calculanoCuota()
        {
            Cuo = Cuo/100;
            CuotaSindical = Cuo * salBasico;
            return CuotaSindical;
        }

        public double calculanoInss()
        {
            innsLaboral = salBasico * 0.07;
            return innsLaboral;
        }


        public double calculanoTotal()
        {
            Total=innsLaboral+Anticipo+CuotaSindical;
            return Total;
        }

        public double calculanoIr()
        {
            throw new NotImplementedException();
        }
    }
}
