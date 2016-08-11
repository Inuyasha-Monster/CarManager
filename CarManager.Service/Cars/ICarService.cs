using CarManager.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Service.Cars
{
    public interface ICarService
    {
        void Create(Car car);
        void Update(Car car);
        void Delete(Car car);
        IEnumerable<Car> GetCars();

    }
}
