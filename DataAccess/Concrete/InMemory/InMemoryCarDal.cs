using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car {CarId=1,BrandId=2,ColorId=1,DailyPrice=50000,ModelYear=2017,Description="2017 Model Taklalı" } ,
            new Car {CarId=2,BrandId=3,ColorId=2,DailyPrice=76000,ModelYear=2018,Description="2018 Model Temiz" },
            new Car {CarId=3,BrandId=2,ColorId=2,DailyPrice=89000,ModelYear=2019,Description="2019 Model Çok Temiz" },
            new Car {CarId=4,BrandId=5,ColorId=3,DailyPrice=78900,ModelYear=2020,Description="2020 Model Bayi Çıkışlı" },
            new Car {CarId=5,BrandId=5,ColorId=1,DailyPrice=27000,ModelYear=2014,Description="2014 Model Kazalı" }};
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carsToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carsToUpdate.CarId = car.CarId;
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;
        }
    }
}
