using System;
using System.Collections.Generic;
using System.Text;

namespace ITEszkoznyilvanitoRendszer
{
    public static class Penzugy
    {
        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * 1.27;
        }
    }
}
