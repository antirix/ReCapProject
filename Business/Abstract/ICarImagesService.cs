using Core.Utilities.Result;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IResult Add(int carId, IFormFile file);
        IResult Update(int id, IFormFile file);
        IResult Delete(int id);
        IDataResult<List<CarImages>> GetByCarImagesId(int carId);
        IDataResult<List<CarImages>> GetAll();
    }
}
