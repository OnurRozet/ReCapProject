using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCarDal
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarContext context=new CarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             
                             on p.BrandId equals c.BrandId
                             select new CarDetailsDto { CarId = p.CarId, BrandName = c.BrandName, CarName = p.CarName,DailyPrice=p.DailyPrice};
                return result.ToList();
            }
        }
    }
}
