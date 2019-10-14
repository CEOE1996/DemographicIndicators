using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsPorcentajesMortalidad
    {
        public decimal Dtm;
        public decimal Dt;
        public decimal PDt

        public clsPorcentajesMortalidad(decimal Dtm, decimal Dt)
        {
            this.Dtm = Dtm;
            this.Dt = Dt;

            PDt = Dtm / Dt * 100;
        }


    }
}
