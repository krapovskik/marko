using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba
{
    public class Aerodrom
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public List<Destination> destinations { get; set; }

        public Aerodrom(string Name,string City,string Code)
        {
            this.Name = Name;
            this.City = City;
            this.Code = Code;
            this.destinations = new List<Destination>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}",Code,Name,City);
        }
    }
}
