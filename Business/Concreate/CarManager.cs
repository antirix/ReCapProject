using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;

namespace Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carService)
        {
            _carDal = carService;
        }
        public IResult Add(Car car)
        {
            if (car.Description.Length >= 5 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.ProductDeleted);
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Lütfen Kurallara uyunuz.");
                return new SuccessResult(Messages.ProductNameInvalid);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetAllByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice > min && p.DailyPrice <= max), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.ProductListed);
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(), Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id), Messages.ProductListed);
        }
    }
}
