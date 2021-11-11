using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte DoorCount { get; set; }
        public int Fuel_Cons { get; set; }


        public Car(string brand, string model, byte doorcount,int fuel_cons) 
        {
            this.Brand = brand;
            this.Model = model;
            this.DoorCount = doorcount;
            this.Fuel_Cons = fuel_cons;
        }

        public string FillInfo(decimal fuel)
        {
            return $"Maşın {fuel}L yanacaqla {(int)(100 * fuel) / this.Fuel_Cons} Km yol qet eder";
        }
    }
}
