using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
       List<CarDetailDTO> GetCarDetails();
    }
}
