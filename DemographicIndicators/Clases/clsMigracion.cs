using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicIndicators.Clases
{
    public class clsMigracion
    {
        /*
        TasaBrutaEmigracionDestinoExtranjero
        TasaBrutaInmigracionProcedenteExtranjero
        TasaBrutaEmigracionDestinoExtranjero
        TasaBrutaInmigracionInterautonomicaInterprovincial
        TASA BRUTA DE EMIGRACIÓN INTERAUTONÓMICA/INTERPROVINCIAL
        */
        public decimal CalculoTasaBruta(decimal numerador, decimal denominador)
        {
            decimal ctb = (numerador / denominador) * 1000;
            return ctb;
        }

        /*
        TasasInmigracionProcedenteExtranjeroPorEdad
        TasasEmigracionDestinoExtranjeroPorEdad
        TasasMigracionInterautonomicaInterprovincialPorEdad
        TASAS DE INMIGRACIÓN INTERAUTONÓMICA/INTERPROVINCIAL POR EDAD
        TASAS DE EMIGRACIÓN INTERAUTONÓMICA/INTERPROVINCIAL POR EDAD
        */
        public decimal CalculoTasasPorEdad(decimal numerador, decimal denominador, decimal edad)
        {
            decimal ctpe = (numerador / denominador) * 1000;
            return ctpe;
        }

        //pendiente 
        //edad media de los inmigrantes procedentes del extranjero 

        //pendiente
        //indicador coyuntural de emigración con destino al extranjero

        //pendiente 
        //edad media a la emigración con destino al extranjero

        //pendiente
        //indicador coyuntural de migracion interautonomica / interprovincial

        public decimal TasaEmigracionBrutaConExtranjero(decimal inmigraciones, decimal emigraciones, decimal poblacion) {
            decimal tebce = ((inmigraciones + emigraciones) / poblacion) * 1000;
            return tebce;
        }

        public decimal TasaMigracionNetaConExtranjero(decimal inmigraciones, decimal emigraciones, decimal poblacion) {
            decimal tmnce = ((inmigraciones - emigraciones) / poblacion) * 1000;
            return tmnce;
        }

        public decimal TasaMigracionInterautonomicaInterprovincialBruta(decimal inmigracionesInteriores, decimal emigracionesInteriores, decimal poblacion) {
            decimal tmiib = ((inmigracionesInteriores + emigracionesInteriores) / poblacion) * 1000;
            return tmiib;
        }

        public decimal TasaMigracionInterautonomicaInterprovincialNeta(decimal inmigracionesInteriores, decimal emigracionesInteriores, decimal poblacion)
        {
            decimal tmiin = ((inmigracionesInteriores - emigracionesInteriores) / poblacion) * 1000;
            return tmiin;
        }

    }
}
