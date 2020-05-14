using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio24
{
    public class Fiesta
    {
        protected int numPersonas;
        protected double CosteDecoracion;
        protected bool DecoracionLujo;
        protected int CosteFijoPersona = 25;

        public int NumPersonas
        {
            get { return numPersonas; }
            set { numPersonas = value; }
        }

        public double costeDecoracion
        {
            get {return CosteDecoracion ;}
            set { CosteDecoracion = value;}
        }
        public bool decoracionLujo
        {
            get {return DecoracionLujo; }
            set {DecoracionLujo = value; }
        }
        public int costeFijoPorPersona
        {
            get {return CosteFijoPersona; }
            set {CosteFijoPersona = value; }
        }
        public double CalcularCosteDecoracion()
        {
            double normal = 7.5;
            double lujo = 15;
            double final;
            if(NumPersonas > 0)
            {
                if(decoracionLujo == false)
                {
                    final = (NumPersonas * normal) + 30;
                    return final;
                }
                else if (decoracionLujo == true)
                {
                    final = (NumPersonas * lujo) + 50;
                    return final;
                }
            }
            
            return 0;
            
        }

        public virtual double CalcularCoste()
        {
            throw new System.NotImplementedException();
        }
    }
}