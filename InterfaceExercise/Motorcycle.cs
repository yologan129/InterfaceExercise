using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Motorcycle : IVehicle, ICompany
    {
        public string CoName { get; set; }
        public string Logo { get; set; }
        public int WheelCount { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int MirrorCount { get; set; }
        public string Make { get; set; }
        public bool HasSattleBags { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {Make}");
        }
    }
}
