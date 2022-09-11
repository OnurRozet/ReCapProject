using Business.Abstract;
using Business.Constant;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalCar;
        public RentalManager(IRentalDal rentalCar)
        {
            _rentalCar = rentalCar;
        }
        public IResult Add(Rental rental)
        {
            var result=_rentalCar.Get(p=>p.CarId==rental.CarId && p.ReturnDate==null);
            if (result==null)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }

           _rentalCar.Add(rental);
            return  new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
           _rentalCar.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalCar.GetAll(),Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalCar.Get(p => p.CarId == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalCar.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
