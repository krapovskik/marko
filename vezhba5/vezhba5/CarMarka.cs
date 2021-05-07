using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba5
{
    public class CarMarka
    {
        public string Code { get; set; }
        public string Marka { get; set; }

        public CarMarka(string code, string marka)
        {
            Code = code;
            Marka = marka;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})",Marka,Code);
        }
    }
}
