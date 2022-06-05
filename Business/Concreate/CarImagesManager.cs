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
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImagesDal;
        public CarImagesManager(ICarImagesDal carImagesDal)
        {
            _carImagesDal = carImagesDal;
        }
        public IResult Add(CarImages carImage)
        {
            _carImagesDal.Add(carImage);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(CarImages carImage)
        {
            _carImagesDal.Delete(carImage);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IResult Update(CarImages carImage)
        {
            _carImagesDal.Update(carImage);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImagesDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<CarImages>> GetByCarId(int id)
        {
            return new SuccessDataResult<List<CarImages>>(_carImagesDal.GetAll(p => p.CarId == id), Messages.ProductListed);
        }
        IDataResult<CarImages> ICarImagesService.GetCarImageId(int id)
        {
            return new SuccessDataResult<CarImages>(_carImagesDal.Get(p => p.Id == id), Messages.ProductListed);
        }
    }
}
