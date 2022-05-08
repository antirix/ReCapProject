using Core.Utilities.Result;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsById(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetAllByUnitPrice(int min, int max);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
