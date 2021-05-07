using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba4
{
    public class Exam
    {
        public string Month { get; set; }
        public int Year { get; set; }
        public List<Zadacha> zadachas { get; set; }

        public Exam(string month, int year)
        {
            Month = month;
            Year = year;
            zadachas = new List<Zadacha>() { new Zadacha(), new Zadacha() };
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}",Month,Year);
        }
    }
}
