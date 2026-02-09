using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11
{
    internal class program3
    {
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
