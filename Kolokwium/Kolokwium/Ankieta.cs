using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
    class Ankieta
    {
        public static int _a;
        public static int _b;
        public static int _c;
        public static int _d;

        public void Deconstruct(out int a, out int b, out int c, out int d, out int suma)
        {
            a = _a;
            b = _b;
            c = _c;
            d = _d;
            suma = a + b + c + d;           
        }


        public void Deconstruct1(int a, int b, int c, int d,int suma, out int procent1, out int procent2, out int procent3, out int procent4)
        {
            procent1 = a / suma;
            procent2 = b / suma;
            procent3 = c / suma;
            procent4 = d / suma;
            
        }



    }
}
