using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetAllByUnitPrice(int min, int max);
        List<CarDetailDTO> GetCarDetails();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
