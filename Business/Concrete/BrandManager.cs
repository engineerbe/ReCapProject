using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandal;

        public BrandManager(IBrandDal brandal)
        {
            _brandal = brandal;
        }

        public void Add(Brand brand)
        {
            _brandal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandal.GetAll();
        }

        public Brand GetBrandById(int brandId)
        {
            return _brandal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            _brandal.Update(brand);
        }
    }
}
