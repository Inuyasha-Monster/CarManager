using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManager.Data.Model;
using CarManager.Core.Data;
using CarManager.Core.Cache;
using CarManager.Core.Infrastructure;
using CarManager.Core.Log;

namespace CarManager.Service.Cars
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> carRepository;

        private readonly ICacheManager cacheManager;

        private const string CarsCacheKey = nameof(CarService) + nameof(Car);

        private readonly ILog logger;

        public CarService(IRepository<Car> carRepository)
        {
            this.carRepository = carRepository;
            this.cacheManager = ServiceContainer.Resole<ICacheManager>("MemcachedCacheManager");
            this.logger = ServiceContainer.Resole<ILog>("MongoDbLogger");
        }


        public void Create(Car car)
        {
            carRepository.Insert(car);
        }

        public void Delete(Car car)
        {
            carRepository.Delete(car);
        }

        public IEnumerable<Car> GetCars()
        {
            var cars = new List<Car>();
            if (cacheManager.Contains(CarsCacheKey))
            {
                cars = cacheManager.Get<List<Car>>(CarsCacheKey);
            }
            else
            {
                cars = carRepository.Table().ToList();
                cacheManager.Set(CarsCacheKey, cars, TimeSpan.FromMinutes(5));
            }
            // tested
            //this.logger.Info(Newtonsoft.Json.JsonConvert.SerializeObject(cars));
            return cars;
        }

        public void Update(Car car)
        {
            carRepository.Update(car);
        }
    }
}
