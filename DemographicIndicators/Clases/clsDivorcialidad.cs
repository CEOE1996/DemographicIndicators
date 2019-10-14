using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsDivorcialidad
    {

        //tasa bruta de divorcios
        //public decimal tdb;

        public decimal TasaBrutaDivorcios(decimal divorcios, decimal poblacion) {
            decimal tbd = ( divorcios / poblacion ) * 1000; 
            return tbd;
        }

        public decimal ProporcionDivorciosSegunDuracionMatrimonio(decimal divorciosDuracion, decimal divorciosAnio) {
            decimal pd = (divorciosDuracion / divorciosAnio) * 100;
            return pd;
        }

        public decimal TasaDivorcialidad(decimal conyuges, decimal poblacion) {
            decimal tdiv = (conyuges / poblacion) * 1000;
            return tdiv;
        }

        public decimal TasasDivorcialidadPorEdad(decimal conyuges, decimal poblacion) {
            decimal tdiv = (conyuges / poblacion) * 1000;
            return tdiv;
        }

        public decimal IndicadorCoyunturalDivorcialidad(decimal conyuges, decimal poblacion, decimal rango) {
            decimal icd = (conyuges / poblacion) * rango;
            return icd;
        }

        //pendiente
        //public decimal EdadMediaDivorcio();

        //pendiente
        //edad media al divorcio
    }
}
