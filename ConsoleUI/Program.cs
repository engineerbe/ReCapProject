using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorId = 1, ColorName = "Black" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Blue" });
            //colorManager.Add(new Color { ColorId = 3, ColorName = "Green" });
            //colorManager.Add(new Color { ColorId = 4, ColorName = "Purple" });
            //colorManager.Delete(new Color { ColorId = 1 });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandId = 1, BrandName = "Toyota" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Mercedes" });
            //brandManager.Add(new Brand { BrandId = 3, BrandName = "Ferrari" });
            //brandManager.Add(new Brand { BrandId = 4, BrandName = "Opel" });
            //brandManager.Add(new Brand { BrandId = 5, BrandName = "Honda" });
            //brandManager.Delete(new Brand { BrandId = 4 });

            CarManager carManager = new CarManager(new EfCarDal());
            

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName);
            }
        }
    }
}
