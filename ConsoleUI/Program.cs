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
            //GetAllCarsTest(); Tested ✓
            //GetByBrandIdTest(); Tested ✓
            //AddCarTest(); Tested ✓
            //AddBrandTest(); Tested ✓
            //GetBrandTest(); Tested ✓
            //AddColorTest(); Tested ✓
            //DTOTest(); Tested ✓







        }

        private static void DTOTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void AddColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            color.ColorId = 2;
            color.ColorName = "White";
            colorManager.Add(color);
        }

        private static void GetBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            brand.BrandName = "Ford";
            brand.BrandId = 3;
            brandManager.Add(brand);
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car12 = new Car();
            car12.BrandId = 2;
            car12.CarName = "Audi A5";
            car12.CarId = 4;
            car12.ColorId = 2;
            car12.ModelYear = 2019;
            car12.DailyPrice = 0;
            car12.Description = "Oto";
            carManager.Add(car12);
        }

        private static void GetAllCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
