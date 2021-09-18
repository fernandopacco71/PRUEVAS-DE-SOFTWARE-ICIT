using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

       // public int resultado { get; set; }


        //public void sumar()
        //{
        //    resultado = num1 + num2;
        //}
        public int sumar()
        {
            return  num1 + num2;
        }

        //public void restar()
        //{
        //    resultado = num1 - num2;
        //}
        public int restar()
        {
            return num1 - num2;
        }

        //public void multiplicar()
        //{
        //    resultado = num1 * num2;
        //}

        //public void dividir()
        //{
        //    resultado = num1 / num2;
        //}

        //public void potencia()
        //{
        //    resultado = (num1 + num2) ^ 2;
        //    resultado = Math.Pow(num1 + num2)
        //}
        //public void radicacion()
        //{
        //    resultado = (int)Math.Sqrt(num1);
        //}
    }
}
