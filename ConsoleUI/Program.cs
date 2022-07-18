using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAllCarsTest(); +
            //GetByIdTest(); +
            //AddCarTest(); +
            //AddBrandTest(); +
            //GetBrandTest(); +



        }

        private static void GetBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            brand.BrandName = "Rolls-Royce";
            brand.BrandId = 2;
            brandManager.Add(brand);
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car12 = new Car();
            car12.BrandId = 1;
            car12.CarId = 7;
            car12.ColorId = 5;
            car12.ModelYear = 2021;
            car12.DailyPrice = 800000;
            car12.Description = "Mercedes";
            carManager.Delete(car12);
        }

        private static void GetAllCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
