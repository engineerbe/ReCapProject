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
            //carManager.Add(new Car { CarId = 1, CarName = "A180", BrandId = 2, ColorId = 1, DailyPrice = 200, ModelYear = 2012 });

            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { UserId = 1, FirstName = "Kemal", LastName = "Unlu", Email = "kemal@123.com", Pasword = 12345 });
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Unlu Holding", CustomerId = 1 });
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentalId = 1, RentDate = DateTime.Now, });

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
