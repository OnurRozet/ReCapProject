using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCarDal
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarContext context = new CarContext())
            {
                var addedCar = context.Entry(entity);
                addedCar.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using (CarContext context = new CarContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetById(Car entity)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetCarByColorId()
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (CarContext context = new CarContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
