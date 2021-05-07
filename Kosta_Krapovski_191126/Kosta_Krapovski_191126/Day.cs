using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta_Krapovski_191126
{
    public class Day
    {
        public string Den { get; set; }
        public string Mesec { get; set; }
        public int Zarazeni { get; set; }
        public int Izlecheni { get; set; }
        public bool Zakluchen { get; set; }

        public Day(string den, string mesec, int zarazeni, int izlecheni)
        {
            Den = den;
            Mesec = mesec;
            Zarazeni = zarazeni;
            Izlecheni = izlecheni;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}",Den,Mesec);
        }

        public override bool Equals(object obj)
        {
            return obj is Day day &&
                   Den == day.Den &&
                   Mesec == day.Mesec;
        }
    }
}
