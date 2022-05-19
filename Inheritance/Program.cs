﻿using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Admin ad = new();
                ad.TestException(null);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
               throw;
            }
            catch(Exception) 
            { 
            
            }
            finally
            {

            }

            Vehicle vehicle1 = new Vehicle("Volvo", "ABC123");
            vehicle1.Test();

            Vehicle vehicle2 = new FuelVehicle("", 34);

            FuelVehicle fuelVehicle55 = (FuelVehicle)vehicle2;
            FuelVehicle fuelVehicle555 = vehicle2 as FuelVehicle;

            if (vehicle2 is FuelVehicle fff)
            {
                fff.Test();
            }


            var resf = fuelVehicle55.Test();
            var res = vehicle2.Test();


            var name = "Kalle";
            var fullname = name.AddString("Anka");
            Console.WriteLine(fullname);


            FuelVehicle fuelVehicle = new(regNo: "ABC123", 100, "SAAB");
            AbstractVehicle abstractVehicle = new FuelVehicle("AAA222", 200, "Volvo");
            var bicycle = new BiCycle();
            AbstractVehicle bicycle2 = new BiCycle();

            var vehicles = new List<IDrivable>()
            {
                new FuelCar(),
                fuelVehicle,
                abstractVehicle,
                bicycle,
                abstractVehicle,
                bicycle2,
                new Vehicle("Volvo", "ABG234")
            };

            var vehicles2 = new IDrivable[] { fuelVehicle, bicycle };

            vehicles2.PrintAll();

            vehicles.PrintAll();

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //BiCycle biCycle = (BiCycle)vehicle;
                //biCycle.SpecialMethod(); 

                // BiCycle? biCycle = vehicle as BiCycle;

                // if (biCycle != null)
                // {
                //     biCycle.SpecialMethod();
                // }

                // biCycle?.SpecialMethod();


                ////if( vehicle.GetType() == typeof(BiCycle))
                //// {

                //// }

                // if(vehicle is BiCycle)
                // {
                //     var biCycle2 = (BiCycle)vehicle;
                //     biCycle2.SpecialMethod();
                // } 

                // if(vehicle is BiCycle bicycle3)
                // {
                //     Console.WriteLine(bicycle3.SpecialMethod());
                // }
            }


        }
    }
}
