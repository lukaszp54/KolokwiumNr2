using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
   public class Gracz
    {
        public int _punkty;
        public int _zwyciestwa;
        public DateTime _ostatniaAktywnosc;

        public Gracz(int punkty, int zwyciestwa, DateTime ostatniaAktywnosc)
        {
            _punkty = punkty;
            _zwyciestwa = zwyciestwa;
            _ostatniaAktywnosc = ostatniaAktywnosc;
        }
    }
}
