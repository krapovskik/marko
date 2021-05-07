using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba3
{
    public class Vozach
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool First { get; set; }
        public List<DateTime> laps  { get; set; }

        public Vozach(string name, int age)
        {
            Name = name;
            Age = age;
            First = false;
            laps = new List<DateTime>();
        }

        public override string ToString()
        {
            return string.Format("{0}({1}) - {2}",Name,Age, First ? "F":"S");
        }
    }
}
