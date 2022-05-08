using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = GetByCarId(rental.CarId);
            if (result.Data==null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.ProductAdded);
            }
            return new ErrorResult(Messages.Error);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.ProductListed);
        }

        public IDataResult<Rental> GetByCarId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<Rental>> GetRentalById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p=>p.Id==id), Messages.ProductListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
