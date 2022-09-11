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
            // BrandTest();
            // ColorTest();
            //CarDto();

            // BrandITest();
            // Test(); 

           
            





            UserManager userManager = new UserManager(new EfUserDal());
            //var result= userManager.Add(new User {  FirstName = "Onur", LastName = "Rozet", Email = "rozetonur@gmail.com", Password = "1234" });

            // Console.WriteLine(result.Message);


            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //var result= rentalManager.Add(new Rental { CarId=5,Id=1,RentDate=DateTime.Now});
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

             CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
           //var result= customerManager.Add(new Customer { UserId = 1, CompanyName = "Deron COmpany" });
           // Console.WriteLine(result.Message);




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

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll().Data)
            {

                Console.WriteLine(item.BrandName);
            };
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void CarDto()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result=carManager.GetCarDetails();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarName + " / " + item.BrandName);
            }
        }

        private static void BrandITest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(item.CarName);
            }
        }

        private static void Test()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName + " " + car.ModelYear + " model " + car.Description);
            }
        }
    }
}
