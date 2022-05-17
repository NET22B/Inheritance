using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public interface IDrivable
    {

        string Drive(int distance);
    }
    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }
           
    }

    internal class Car : Vehicle
    {
        public string Make { get; set; }
        public Car(string make, string brand = "default brand") :base(brand)
        {
            Make = make;
        }

        public override string Drive(int distance)
        {
            return base.Drive(distance) + " From Car";
        }

    }
}
