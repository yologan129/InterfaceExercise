using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

           

           

           
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
 
            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

                var sedan = new Car();

            sedan.Make = "Honda";
            sedan.TrunkSpace = 4;
            sedan.MirrorCount = 2;
            sedan.WheelCount = 4;
            sedan.HasSteeringWheel = true;
            sedan.Logo = "H";

            var f150 = new Truck();
            f150.TruckBedSpace = 8;
            f150.Make = "Ford";
            f150.WheelCount = 4;
            f150.MirrorCount = 2;


            var harley = new Motorcycle();
            harley.HasSattleBags = true;
            harley.Make = "Harley";
            harley.MirrorCount = 2;
            harley.WheelCount = 2;

            var carLot = new List<IVehicle>();

            Console.WriteLine($"This is a {sedan.Make}. It has {sedan.MirrorCount} mirrors, and it has {sedan.WheelCount} wheels.");
            Console.WriteLine($"This is a {f150.Make}. It has {f150.MirrorCount} mirrors, and it has {f150.WheelCount} wheels.");
            Console.WriteLine($"This is a {harley.Make}. It has {harley.MirrorCount} mirrors, and it has {harley.WheelCount} wheels.");
        }
    }
}
