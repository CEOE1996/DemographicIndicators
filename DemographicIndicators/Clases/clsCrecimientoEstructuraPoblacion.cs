using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    class clsCrecimientoEstructuraPoblacion
    {
        /*
        CRECIMIENTO DE LA POBLACIÓN POR MIL HABITANTES
        SALDO VEGETATIVO POR MIL HABITANTES
        SALDO MIGRATORIO POR MIL HABITANTES
        */
        public decimal CalculoCrecimientoPorMil(decimal numeradorPositivo, decimal numeradorResta, decimal denominador) {
            decimal ccpm = ((numeradorPositivo - numeradorResta) / denominador) * 1000;
            return ccpm;
        }

        public decimal NacidosCadaMilDefunciones(decimal nacimientos, decimal defunciones) {
            decimal rnd = (nacimientos / defunciones) * 1000;
            return rnd;
        }

        /*
        RATIO DE MASCULINIDAD DE LA POBLACIÓN 
        PROPORCIÓN DE POBLACIÓN NACIDA EN EL EXTRANJERO
        PROPORCIÓN DE POBLACIÓN EXTRANJERA
        PROPORCIÓN DE PERSONAS MAYORES DE CIERTA EDAD
        ÍNDICE DE ENVEJECIMIENTO
        TASA DE DEPENDENCIA DE LA POBLACIÓN MENOR DE 16 AÑOS
        TASA DE DEPENDENCIA DE LA POBLACIÓN MAYOR DE 64 AÑOS
        */
        public decimal ReglaDeTres(decimal numerador, decimal denominador) {
            decimal rdt = (numerador / denominador) * 100;
            return rdt;
        }

        //pendiente
        //edad media de la población

        public decimal EdadMedianaPoblacion(decimal edadMed, decimal poblacion, decimal individuosInferiorEdadMed, decimal individuosIgualEdadMed) {
            decimal emp = edadMed * (((poblacion / 2) - individuosInferiorEdadMed) / individuosIgualEdadMed);
            return emp;
        }

        public decimal TasaDependencia(decimal poblacionMayor64, decimal poblacionMayor15Menor65, decimal poblacionMenor16) {
            decimal td = ((poblacionMenor16 + poblacionMayor64) / poblacionMayor15Menor65) * 100;
            return td;
        }


    }
}
