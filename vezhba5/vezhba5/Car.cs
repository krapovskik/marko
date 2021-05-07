using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba5
{
    public class Car
    {
        public CarMarka Marka { get; set; }
        public string Model { get; set; }
        public decimal Potroshuvachka { get; set; }
        public int Cena { get; set; }

        public Car(CarMarka marka, string model, decimal potroshuvachka, int cena)
        {
            Marka = marka;
            Model = model;
            Potroshuvachka = potroshuvachka;
            Cena = cena;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",Marka.Marka,Model,Potroshuvachka.ToString(".0"),Cena);
        }
    }
}
