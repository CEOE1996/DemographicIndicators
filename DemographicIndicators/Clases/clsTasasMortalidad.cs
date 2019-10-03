using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsTasasMortalidad
    {
        public decimal Dt;
        public decimal NVt;

        public decimal TMIt;
        public decimal TMINt;
        public decimal TMINTemp;
        public decimal TMINtardía;
        public decimal TMIPNt;
        public decimal TMFTt;
        public decimal TMPt;

        public clsTasasMortalidad(decimal Dt, decimal NVt)
        {
            this.Dt = Dt;
            this.NVt = NVt;

            TMIt = (Dt / NVt) * 1000;
            TMINt = (Dt / NVt) * 1000;
            TMINTemp = (Dt / NVt) * 1000;
            TMINtardía = (Dt / NVt) * 1000;
            TMIPNt = (Dt / NVt) * 1000;
            TMFTt = (Dt / (NVt + Dt)) * 1000;
        }

        public decimal Perinatal(decimal MFTt)
        {
            TMPt = (MFTt + Dt) / (NVt + MFTt) * 1000;
            return TMPt;
        }
    }
}
