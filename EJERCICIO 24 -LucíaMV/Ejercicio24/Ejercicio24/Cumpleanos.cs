using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio24
{
    public class Cumpleanos : Fiesta
    {
        protected int TamanoTarta;
        protected int TextoTarta;
        protected double PrecioTarta;
        public int tamanoTarta
        {
            get {return TamanoTarta; }
            set {TamanoTarta = value; }
        }
        public int textoTarta
        {
            get {return TextoTarta; }
            set {TextoTarta = value; }
        }
        public double precioTarta
        {
            get { return PrecioTarta; }
            set { PrecioTarta = value; }
        }
        public override double CalcularCoste()
        {
            double precioPagar;
            precioTarta = tamanoTarta + ( 0.25 * textoTarta);
            
            if (NumPersonas == 0)
            {
                precioPagar = 0;
                return precioPagar;
            }
            else if (NumPersonas > 0)
            {
                precioPagar = (NumPersonas * costeFijoPorPersona) + precioTarta + CalcularCosteDecoracion();
                return precioPagar;
                
            }
            precioPagar = 0;
            return precioPagar;
        }
    }
}