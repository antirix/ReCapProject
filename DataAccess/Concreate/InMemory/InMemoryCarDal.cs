using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=450000,Description="Sahibinden Hatasız"},
                new Car{Id=2, BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=150000,Description="Sahibinden Hatalı"},
                new Car{Id=3, BrandId=3,ColorId=5,ModelYear=2015,DailyPrice=250000,Description="Taklalı"},
                new Car{Id=4, BrandId=4,ColorId=6,ModelYear=2017,DailyPrice=330000,Description="Tavan Boyalı"},
                new Car{Id=5, BrandId=2,ColorId=4,ModelYear=2022,DailyPrice=450000,Description="Yeni Model"},
                new Car{Id=6, BrandId=4,ColorId=3,ModelYear=2012,DailyPrice=600000,Description="Çiziksiz"},
                new Car{Id=7, BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=450000,Description="Yeni Gibi"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }
        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
