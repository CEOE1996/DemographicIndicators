using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsNupcialidad
    {
        public decimal Mt;
        public decimal Pt;
        public decimal Ct;

        public decimal TBNup;
        public decimal TNup;
        public decimal TPNup;

        public clsNupcialidad(decimal val1, decimal val2)
        {
            Mt = val1;
            Ct = val1;

            Pt = val2;

            TBNup = Ct / Pt * 1000;
            TNup = Ct / Pt * 1000;
            TPNup = Ct / Pt * 1000;
        }

    }
}
