using Business.Concreate;
using DataAccess.Concreate.EntityFramwork;
using Entities.Concreate;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            UserManager userManager = new UserManager(new EfUserDal());
            
            userManager.Add(new User {Id=3, FirstName="Kerem11",LastName="Yıldız121", Email="ker1231em@kerem.com",Password="kere1123m123"});
            
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { CompanyName = "kerem co.",UserId=1 });
            */
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { Id = 7, CarId=1, CustomerId=2,RentDate=DateTime.Parse("12/02/2022"), ReturnDate = DateTime.Parse("13/02/2022")});


            //CarList();
            //BrandList();
            //ColorList();
        }
        /*
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
        }*/
    }
}
