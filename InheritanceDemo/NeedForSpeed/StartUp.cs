using System;

namespace NeedForSpeed
{
   public  class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehile = new Vehicle(300, 100);
            Car car = new Car(300, 100);
            vehile.Drive(10);
            car.Drive(10);

            Console.WriteLine(vehile.Fuel);
            Console.WriteLine(car.Fuel);
        }
    }
}
