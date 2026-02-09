using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    internal class program3
    {
        //Create a C# program that implements an IVehicle interface with two methods, one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. \ Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the IVehicle.
        //The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. The Refuel method will increase the gasoline of the car and return true. To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.
        //Input
        //50
        //Output
        //Driving


        public static void Main()
        {

            Car myCar = new Car(0); 

            Console.Write("Enter amount of gasoline to refuel: ");
            int amount = int.Parse(Console.ReadLine());

            myCar.Refuel(amount); 
            myCar.Drive(); 

        }
    }
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int refuelQuantity);
    }
    public class Car:IVehicle
    {
        protected int beginRefuel;
        public Car(int beginRefuel)
        {
            this.beginRefuel = beginRefuel;
        }

        public void Drive()
        {
            if (beginRefuel>0)
            {
                Console.WriteLine("Driving");
            }
        }

        public bool Refuel(int refuelQuantity)
        {
            beginRefuel += refuelQuantity;
            return true;
        }
    }
}
