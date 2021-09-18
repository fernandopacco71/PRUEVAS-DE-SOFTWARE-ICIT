using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Opercaciones
    {
        int x;
        string f;
        public string primo
        {
            get
            {
                return f;
            }
            set
            {
                x = Convert.ToInt16(value);
                int acu = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        acu++;
                    }
                }
                if (acu == 2)
                {
                    f ="el numero " + x + " es primo";
                }
                else
                {
                    f ="el numero " + x + " no es primo";
                }
            }
        }
        public string par_impar
        {
            get
            {
                return f;
            }
            set
            {
                x = Convert.ToInt16(value);
                if ((x % 2) == 0)
                {
                    f = "el numero "+ x +" es par";
                }
                else
                {
                    f = "el numero " + x + " es impar";
                }
            }
        }
        public string divisible5
        {
            get
            {
                return f;
            }
            set
            {
                x = Convert.ToInt16(value);
                if (x % 5 == 0)
                {
                    f = "el numero "+ x + " es divisble entre 5";
                }
                else
                {
                    f = "el numero " + x + " no es divisble entre 5";
                }
            }
        }
        public string perfecto
        {
            get
            {
                return f;
            }
            set
            {
                x = Convert.ToInt16(value);
                int resultado;
                int suma = 0;
                for (int i = 1; i < x; i++)
                {
                    resultado = x % i;
                    if (resultado == 0)
                    {//si el resultado da 0 entonces se suma
                        suma = suma + i;
                    }
                }
                if (suma == x)
                {
                    f = "el numero " + x + " es perfecto";
                }
                else
                {
                    f = "el numero " + x + " no es perfecto";
                }
            }
        }
    }
}
