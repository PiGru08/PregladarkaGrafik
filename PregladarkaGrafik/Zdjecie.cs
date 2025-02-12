using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregladarkaGrafik
{
    public class Zdjecie
    {

        public string NazwaZdjecia { get; set; }
        public int LiczbaWyswietlen { get; set; }
        public int LiczbaPolubien { get; set; } = 1;


        public Zdjecie(string nazwaZdjecia, int liczbaWyswietlen, int liczbaPolubien)
        {
            NazwaZdjecia = nazwaZdjecia;
            LiczbaWyswietlen = liczbaWyswietlen;
            LiczbaPolubien = liczbaPolubien;
        }
    }
}
