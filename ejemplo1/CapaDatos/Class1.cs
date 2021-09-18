using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int resultado { get; set; }

        public void sumar(int a, int b)
        {
            resultado = num1 + num2;
        }

        //int x;
        //public string propiedad
        //{
        // get
        // {
        //     return x;
        // }
        // set
        // {
        //      x = value;
        //  }
        // }
    }
}
