using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public void Drive();
        public void Maintenance();
        public void PrintSummary();
    }
}
