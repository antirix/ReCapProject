using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;

namespace Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carService)
        {
                _carDal = carService;
        }
        public void Add(Car car)
        {
            if (car.Description.Length >= 5 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else {
                Console.WriteLine("Hatalı giriş. Lütfen Kurallara uyunuz.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=> p.BrandId==id);
        }

        public List<Car> GetAllByUnitPrice(int min, int max)
        {
            return _carDal.GetAll(p => p.DailyPrice > min && p.DailyPrice <= max);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetCarsByColorId(int id)
        {
           return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
