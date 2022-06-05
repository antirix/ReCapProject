using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImagesDal;
        IFileHelper _fileHelper;

        public CarImagesManager(ICarImagesDal carImagesDal, IFileHelper fileHelper)
        {
            _carImagesDal = carImagesDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(int carId, IFormFile file)
        {
            var result = BusinessRules.Run(CheckCarImagesCount(carId));
            if (result.Success)
            {
                var carImage = new CarImages
                {
                    CarId = carId,
                    Date = DateTime.Now,
                    ImagePath = _fileHelper.Add(file)
                };
                _carImagesDal.Add(carImage);
                return new SuccessResult(Messages.ProductAdded);
            }
            return result;

        }

        public IResult Delete(int id)
        {
            var carImage = _carImagesDal.Get(c=> c.Id == id);
            _fileHelper.Delete(carImage.ImagePath);
            _carImagesDal.Delete(carImage);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IResult Update(int id, IFormFile file)
        {
            var carImage = _carImagesDal.Get(c => c.Id == id);
            carImage.ImagePath = _fileHelper.Update(file, carImage.ImagePath);

            _carImagesDal.Update(carImage);
            return new SuccessResult(Messages.ProductUpdated);
        }

        /*******************************GetMetods*******************************/


        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImagesDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<CarImages>> GetByCarImagesId(int id)
        {
            var result = _carImagesDal.GetAll(p => p.CarId == id);
            return new SuccessDataResult<List<CarImages>>(result, Messages.ProductListed);
        }
        public IDataResult<CarImages> GetCarImageId(int id)
        {
            return new SuccessDataResult<CarImages>(_carImagesDal.Get(p => p.Id == id), Messages.ProductListed);
        }

        /*******************************Rules*******************************/

        private IResult CheckCarImagesCount(int id)
        {
            var result = _carImagesDal.GetAll(p => p.CarId == id).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.MaxCarImage);
            }
            return new SuccessResult();
        }




    }
}
