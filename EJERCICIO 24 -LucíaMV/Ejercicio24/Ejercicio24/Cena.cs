using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio24
{
    public class Cena : Fiesta
    {
        protected bool OpcionSaludable;
        protected double CosteBebidaPorPersona;
        public bool opcionSaludable
        {
            get {return OpcionSaludable; }
            set {OpcionSaludable = value; }
        }
        public double costeBebidaPorPersona
        {
            get {return CosteBebidaPorPersona; }
            set {CosteBebidaPorPersona = value; }
        }
        public override double CalcularCoste()
        {
            //persona 25€
            // LISTO decoracion normal 7.5€ cargo final 30€ y lujo 15€ 50€ final
            //LISTOalcohol 20€ por persona
            //LISTO %%%% saludable 5€ por persona y 5% descuento al total
            //;
            double precioPagar;
            if(NumPersonas == 0)
            {
                precioPagar = 0;
                return precioPagar;
            }
            else if(NumPersonas > 0)
            {
                precioPagar = (NumPersonas * costeFijoPorPersona) + CalcularCosteDecoracion() + EstablecerOpcionSaludable();

                if (OpcionSaludable == true)
                {
                    precioPagar = precioPagar * 0.95;
                    return precioPagar;
                }
                return precioPagar;
            }
            precioPagar = 0;
            return precioPagar;
            
        }

        public double EstablecerOpcionSaludable()
        {
            double opcion;
            if(NumPersonas > 0){
                if (OpcionSaludable == true)
                {
                    opcion = (5 * NumPersonas);
                    return opcion;
                }
                opcion = (20 * NumPersonas);
                return opcion;
            }
            return 0;
            
        }
    }
}