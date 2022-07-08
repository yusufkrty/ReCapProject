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

            CarManager carManager = new CarManager(new EfCarDal());
            //Car car5 = new Car();
            //car5.CarId = 45;
            //car5.BrandId = 2;
            //car5.ColorId = 4;
            //car5.DailyPrice = 18000000;
            //car5.ModelYear = 2020;
            //car5.Description = "RR Wraith";

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("*****************************************");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            //carManager.Add(car5);

            
            




        }
    }
}
