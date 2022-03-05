using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand { BrandId = 1 , BrandName="MERCEDES"},
                new Brand { BrandId = 2 , BrandName="BWM"},
                new Brand { BrandId = 3 , BrandName="SUBARU"},
                new Brand { BrandId = 4 , BrandName="TOYOTA"},
                new Brand { BrandId = 5 , BrandName="AUDI"},
                new Brand { BrandId = 6 , BrandName="VOLKSWAGEN"},
                new Brand { BrandId = 7 , BrandName="SKODA"},

            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(p => p.BrandId==brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetById(int brandId)
        {
            return _brands.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
