using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;

namespace Business.Concreate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorService)
        {
            _colorDal = colorService;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Color>> GetColorById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id), Messages.ProductListed);
        }

    }
}
