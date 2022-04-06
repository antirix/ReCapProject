using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
       public List<CarDetailDTO> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from p in context.Car
                             join c in context.Color on p.ColorId equals c.ColorId
                             join b in context.Brand on p.BrandId equals b.BrandId
                             select new CarDetailDTO
                             {
                                 CarId = p.Id, BrandName = b.BrandName, ColorName = c.ColorName,
                                 ModelYear = p.ModelYear, DailyPrice = p.DailyPrice, Description = p.Description
                             };
           
                return result.ToList();
            }
        }
    }
}
