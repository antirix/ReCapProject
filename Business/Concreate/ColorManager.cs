using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetColorById(int id)
        {
            return _colorDal.GetAll(p=>p.ColorId==id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
