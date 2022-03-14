using System;

namespace car_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Lamborghini";
            car1.Model = "Urus";
            car1.FuelCapaCity = 85;
            car1.FuelFor1Km = 2;
            car1.CurrentFuel = 60;
            car1.Color = "Yellow";
            car1.Year = 2019;

            car1.ShowInfo();
            car1.Drive(45);
        }
    }
}
