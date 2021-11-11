using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface ICompany
    {
        public string CoName { get; set; }
        public string Logo { get; set; }
        /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
    }
}
