using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
namespace DataAccess.Concreate.EntityFramwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalsDetailDTO> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from r in context.Rental
                             join c in context.Customer on r.CustomerId equals c.UserId
                             join ca in context.Car on r.CarId equals ca.Id
                             select new RentalsDetailDTO
                             {
                                 Id = r.Id,
                                 CustomerCompany = c.CompanyName,
                                 CarBrand = ca.BrandId,
                                 CardColor = ca.ColorId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
