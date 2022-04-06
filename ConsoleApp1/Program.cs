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







            //CarList();
            //BrandList();
            //ColorList();
        }

        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
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
        }
        private static void ColorList()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("ColorId: {0} , ColorName: {1} ", color.ColorId, color.ColorName);
                Console.WriteLine("************");
            }
        }
        private static void BrandList()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("BrandId: {0} ,:BrandName: {1} ", brand.BrandId, brand.BrandName);
                Console.WriteLine("************");
            }
        }
    }
}
