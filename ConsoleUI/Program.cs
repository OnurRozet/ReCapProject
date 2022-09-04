using Business.Concrete;
using DataAccess.Concrete.EntityFrameworkCarDal;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " " + car.ModelYear + " model " + car.Description);
            }

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine("{0} id ile listelenen araclar : " + car.BrandId ,2);
            //}

            //carManager.Add(new Car { CarId = 10, ColorId = 2, BrandId = 6, DailyPrice = 4670, ModelYear = 2012, Description = "Ferrari" ,CarName="Ferrari"});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
