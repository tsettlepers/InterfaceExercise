using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public string Spokesperson { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Purrrrrrr");
        }

        public void Jingle()
        {
            Console.WriteLine($"{Spokesperson} says, \"Buy our car!\"");
        }

        public void Maintenance()
        {
            Console.WriteLine("Take me in for car maintenance, please.");
        }

        public void PrintSummary()
        {
            Console.WriteLine("---");
            Console.WriteLine($"Car summary: {Make} {Model} hyped by {Spokesperson}");
        }
    }
}
