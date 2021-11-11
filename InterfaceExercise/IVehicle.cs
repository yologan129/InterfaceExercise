using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int WheelCount { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int MirrorCount { get; set; }
        public string Make { get; set; }
    }
}
