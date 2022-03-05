using Business.Concreate;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager  carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
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
            carManager.Add(new Entities.Concreate.Car { Id = 10, ColorId = 2, BrandId = 1, ModelYear = 2024, DailyPrice = 25000, Description = "Kusursuz" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("car Id: " + car.Id);
                Console.WriteLine("car colorıd: " + car.ColorId);
                Console.WriteLine("car brandıd: " + car.BrandId);
                Console.WriteLine("car modelyıl: " + car.ModelYear);
                Console.WriteLine("car price: " + car.DailyPrice);
                Console.WriteLine("car description: " + car.Description);
                Console.WriteLine("************");
            }
            Console.WriteLine("------------------------------------------------------");
            carManager.Update(new Entities.Concreate.Car { Id = 10, ColorId = 1, BrandId = 6, ModelYear = 2022, DailyPrice = 21000, Description = "Kusursuz değil 21" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("car Id: " + car.Id);
                Console.WriteLine("car colorıd: " + car.ColorId);
                Console.WriteLine("car brandıd: " + car.BrandId);
                Console.WriteLine("car modelyıl: " + car.ModelYear);
                Console.WriteLine("car price: " + car.DailyPrice);
                Console.WriteLine("car description: " + car.Description);
                Console.WriteLine("************");
            }
            Console.WriteLine("------------------------------------------------------");
            carManager.Delete(new Entities.Concreate.Car { Id = 1});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("car Id: " + car.Id);
                Console.WriteLine("car colorıd: " + car.ColorId);
                Console.WriteLine("car brandıd: " + car.BrandId);
                Console.WriteLine("car modelyıl: " + car.ModelYear);
                Console.WriteLine("car price: " + car.DailyPrice);
                Console.WriteLine("car description: " + car.Description);
                Console.WriteLine("************");
            }

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);

            //}
            //Console.WriteLine("------------------------------------------------------");
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);

            //}

        }
    }
}
