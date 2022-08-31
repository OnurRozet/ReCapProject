using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{

    public class CarDal : ICarDal
    {
        List<Car> cars;

        public CarDal()
        {
            cars = new List<Car> { new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = 2022, Description = "Kirmizi Ferrari", CarName = "Ferrari" },
                                   new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 2500, ModelYear = 2018, Description = "Beyaz Porsche", CarName = "Porsche" },
                                   new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 500, ModelYear = 2015, Description = "Patron Arabasi", CarName = "WW Passat" } };

        }





        public void Add(Car car)
        {
            cars.Add(car); 
        }

        public void Delete(Car car)
        {
            Car deletedToCar = cars.Where(x=>x.CarId==car.CarId).FirstOrDefault();
            cars.Remove(deletedToCar);

        }

        public List<Car> GetAll(Car car)
        {
            return cars;
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int Id)
        {
            return cars.Where(x => x.CarId == Id).ToList();
        }

        public List<Car> GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedCar = cars.Where(x => x.CarId == car.CarId).FirstOrDefault();
            updatedCar.CarId = car.CarId;
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.CarName = car.CarName;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.Description = car.Description;
            updatedCar.DailyPrice = car.DailyPrice;
           

        }
    }






}
