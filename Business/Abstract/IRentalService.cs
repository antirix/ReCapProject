using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalById(int id);
        IDataResult<Rental> GetByCarId(int id);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
