using Business.Concreate;
using DataAccess.Concreate.EntityFramwork;
using Entities.Concreate;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager  carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("car Id: "+car.Id);
                Console.WriteLine("car colorıd: "+car.ColorId);
                Console.WriteLine("car brandıd: "+car.BrandId);
                Console.WriteLine("car modelyıl: "+car.ModelYear);
                Console.WriteLine("car price: "+car.DailyPrice);
                Console.WriteLine("car description: "+car.Description);
                Console.WriteLine("************");
            }
            Console.WriteLine("------------------------------------------------------");
            //carManager.Add(new Car {ColorId=3, BrandId=2,ModelYear=2012, DailyPrice=6556, Description="1231s"});
            foreach (var brand in brandManager.GetAll()) 
            {
                Console.WriteLine("BrandId: {0} ,:BrandName: {1} ", brand.BrandId, brand.BrandName);
                Console.WriteLine("************");
            }
            Console.WriteLine("------------------------------------------------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("ColorId: {0} , ColorName: {1} ", color.ColorId, color.ColorName);
                Console.WriteLine("************");
            }

        }
    }
}
