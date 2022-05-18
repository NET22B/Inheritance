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

    public abstract class AbstractVehicle : IDrivable
    {

        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }

        public abstract string Turn();
    }



    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; private set; }
        public string RegNo { get; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle Turns";
        }
    }

    internal class FuelVehicle : Vehicle
    {
        public FuelVehicle(string regNo, string brand = "default brand") : base(brand, regNo)
        {

        }

        public override string Drive(int distance)
        {
            return base.Drive(distance) + " From Car";
        }

    }


    //internal class FuelCar : FuelVehicle
    //{
    //}

    public class BiCycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }

        public override string Drive(int distance)
        {
            return string.Format("Bicycle starts pedaling {0}", distance);
        }

        public string SpecialMethod()
        {
            return "From specialmethod";
        }
    }
}
