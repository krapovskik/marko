using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba
{
    public class Destination
    {
        public string City { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }

        public Destination(string City,int Distance,int Price)
        {
            this.City = City;
            this.Distance = Distance;
            this.Price = Price;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}km - {2}EUR", City, Distance, Price);
        }
    }
}
