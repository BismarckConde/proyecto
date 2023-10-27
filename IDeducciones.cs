using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public interface IDeducciones
    {
        public double salBasico { get; set; }
        public double innsLaboral { get; set; }
        public double IR { get; set; }
        public double CuotaSindical { get; set; }
        public double Anticipo { get; set; }
        public double Total { get; set; }
        public double calculanoInss();
        public double calculanoIr();
        public double calculanoCuota();
        public double calculanoTotal();


    }
}
