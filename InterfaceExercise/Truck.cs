using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public string Spokesperson { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Growwwwwwl");
        }

        public void Jingle()
        {
            Console.WriteLine($"{Spokesperson} says, \"Buy our truck!\"");
        }

        public void Maintenance()
        {
            Console.WriteLine("Take me in for truck maintenance, please.");
        }

        public void PrintSummary()
        {
            Console.WriteLine("---");
            Console.WriteLine($"Truck summary: {Make} {Model}");
        }
    }
}
