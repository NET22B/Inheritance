using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelVehicle fuelVehicle = new(regNo: "ABC123", "SAAB");
            AbstractVehicle abstractVehicle = new FuelVehicle("AAA222", "Volvo");
            var bicycle = new BiCycle();
            AbstractVehicle bicycle2 = new BiCycle();

            var vehicles = new List<AbstractVehicle>()
            {
                fuelVehicle,
                abstractVehicle,
                bicycle,
                abstractVehicle,
                bicycle2,
                new Vehicle("Volvo", "ABG234")
            };

            foreach (AbstractVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Turn());

                //BiCycle biCycle = (BiCycle)vehicle;
                //biCycle.SpecialMethod(); 

                BiCycle? biCycle = vehicle as BiCycle;

                if (biCycle != null)
                {
                    biCycle.SpecialMethod();
                }

                biCycle?.SpecialMethod();


               //if( vehicle.GetType() == typeof(BiCycle))
               // {

               // }

                if(vehicle is BiCycle)
                {
                    var biCycle2 = (BiCycle)vehicle;
                    biCycle2.SpecialMethod();
                } 
                
                if(vehicle is BiCycle bicycle3)
                {
                    Console.WriteLine(bicycle3.SpecialMethod());
                }
            }
           
         
        }
    }
}
