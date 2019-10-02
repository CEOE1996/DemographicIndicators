using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators
{
    public class clsNatalidad
    {
        public decimal Nt;
        public decimal Pt;
        public decimal Mt;

        public decimal TBNt;
        public decimal RMNt;
        public decimal TGFt;
        public decimal TEFt;

        public clsNatalidad(decimal Nt, decimal Pt, decimal Mt)
        {
            this.Nt = Nt;
            this.Pt = Pt;
            this.Mt = Mt;

            TBNt = (Nt / Pt) * 1000;
            TGFt = (Nt / Mt) * 1000;
            TEFt = (Nt / Mt) * 1000;
        }

        public decimal RatioMasculinidad(decimal NtH, decimal NtM)
        {
            RMNt = (NtH / NtM) * 100;
            return RMNt;
        }




    }
}
