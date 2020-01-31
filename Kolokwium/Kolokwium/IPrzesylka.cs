using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
    public interface IPrzesylka
    {
        public int Nadaj();
        public void Przekaz(string przekaz);

         public void Info();

        public void Odbierz(int odbierz);


      

    }
}
