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
            return $"{this.GetType().Name} wants to drive for {distance}";
        }

        public abstract string Turn();
    }



    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; private set; }
        protected string RegNo { get; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle Turns";
        }

        public string Test()
        {
            return "From Vehicle";
        }
    }

    internal class FuelVehicle : Vehicle
    {
        public new string Test()
        {
            return "From FuelVehicle";
        }

        private double fuelLevel;

        public double FuelLevel
        {
            get { return fuelLevel; }
            set 
            { 
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            }
        }

        public double FuelCapacity { get; }
        public FuelVehicle(string regNo, double fuelCapacity, string brand = "default brand") : base(brand, regNo)
        {
            //Validate
            FuelCapacity = fuelCapacity;
        }

        public override string Drive(int distance)
        {
            return base.Drive(distance) + " ( From Car ) ";
        }

    }


    internal class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double MaxDistance => FuelLevel / fuelConsumption; 
        //{
        //    get
        //    {
        //        return FuelLevel / fuelConsumption;
        //    }
        //}
        public FuelCar() : this(100, "DefaultBrandName") { }
        public FuelCar(double fuelCapacity, string brand, string regno = "ABC123") : base(regno, fuelCapacity, brand){}

        public sealed override string Drive(int distance)
        {
            var result = new StringBuilder();

            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine("Nagative distance is asssumed to be 0");
            }

            FuelLevel -= distance * fuelConsumption;
            // FuelLevel = FuelLevel -  distance * fuelConsumption;

            result.AppendLine($"RegNo: {RegNo} drowe for {distance}km");

            return result.ToString();

        }
    }

    //public class FuelVolvo : FuelCar
    //{
    //    override 
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
