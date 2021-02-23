using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            _CarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _CarDal.GetAll();
        }

     
        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    } 
}
