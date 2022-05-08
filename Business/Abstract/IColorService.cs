using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetColorById(int id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
