using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IDataResult<List<CarImages>> GetAll();
        IDataResult<CarImages> GetCarImageId(int id);
        IDataResult<List<CarImages>> GetByCarId(int id);
        IResult Add(CarImages carImage);
        IResult Update(CarImages carImage);
        IResult Delete(CarImages carImage);
    }
}
