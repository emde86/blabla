using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matha
{
    public class Count
    {
        public int Dodaj(int liczba1, int liczba2)
        {
            if (liczba1 > 0)
            {
                liczba1 += 10;
            }

            liczba2 /= 2;

            return liczba1 + liczba2;
        }
    }
}
