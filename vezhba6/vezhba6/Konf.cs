using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba6
{
    public class Konf
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public Konf(int year, string name)
        {
            Year = year;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Year, Name); ;
        }
    }
}
