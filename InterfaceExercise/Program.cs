using System;

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
            var myCar = new Car() { Make = "Toyota", Model = "Camry", Spokesperson = "Toyota Jan" };
            myCar.PrintSummary();
            myCar.Jingle();
            myCar.Drive();
            myCar.Maintenance();
          
            var myTruck = new Truck() { Make = "Ford", Model = "Ranger", Spokesperson = "Mike Rowe" };
            myTruck.PrintSummary();
            myTruck.Jingle();
            myTruck.Drive();
            myTruck.Maintenance();

            var mySUV = new Car() { Make = "Honda", Model = "Pilot", Spokesperson = "John Cena" };
            mySUV.PrintSummary();
            mySUV.Jingle();
            mySUV.Drive();
            mySUV.Maintenance();

            // I just did this experiment to see what's available
            Console.ReadLine();
            object[] wheels= { myCar, myTruck,mySUV };
            foreach (object o in wheels)
                Console.WriteLine(o);   //barebones members

            //Is there a way to use the interfaces??  Yes, but I don't see how I can use both. And if I try "cheating" like I did in the PrintSummary method, it chirps at me.
            //IVehicle[] vehicles= {myCar, myTruck,mySUV};
            //foreach (var v in vehicles)
                //Console.WriteLine(v.PrintSummary());

            /* I have no doubt that there are good reasons for interfaces, because it was added to the language by people waaaaaay smarter than me.
             * But in this particular example, it seems like an abstract class would have been a much better fit. */
            
        }
    }
}
