using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName="Beyaz"},
                new Color{ColorId=2, ColorName="Siyah"},
                new Color{ColorId=3, ColorName="Gri"},
                new Color{ColorId=4, ColorName="Mor"},
                new Color{ColorId=5, ColorName="Mavi"},
                new Color{ColorId=6, ColorName="Kırmızı"},
                new Color{ColorId=7, ColorName="Sarı"},

            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }
        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(p => p.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }
        public List<Color> GetById(int colorId)
        {
            return _colors.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(p => p.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }
        public List<Color> GetAll()
        {
            return _colors;
        }
    }
}
