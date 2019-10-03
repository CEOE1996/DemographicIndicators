using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsMortalidad
    {
        public decimal Dt;
        public decimal Pt;

        public decimal TBMt;
        public decimal TMt;
        public decimal mt;
        public decimal RMDt;

        public clsMortalidad(decimal Dt, decimal Pt)
        {
            this.Dt = Dt;
            this.Pt = Pt;

            TBMt = (Dt / Pt) * 1000;
            TMt = (Dt / Pt) * 1000;
            mt = (Dt / Pt) * 1000;
        }

        public decimal RatioMasculinidad(decimal DtHombres, decimal DtMujeres)
        {
            RMDt = (DtHombres / DtMujeres) * 100;
            return RMDt;
        }
    }
}
