using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " "  + car.ModelYear + " model " + car.Description);
            }
        }
    }
}
