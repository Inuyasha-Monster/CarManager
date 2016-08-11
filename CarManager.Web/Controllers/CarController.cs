using AutoMapper;
using CarManager.Data.Model;
using CarManager.Service.Cars;
using CarManager.Web.Models.Cars;
using CarManager.WebCore.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.Controllers
{
    public class CarController : BaseController
    {
        private readonly ICarService carService;

        private readonly IMapper mapper;

        private readonly MapperConfiguration config;

        public CarController(ICarService carService, IMapper mapper, MapperConfiguration config)
        {
            this.carService = carService;
            this.mapper = mapper;
            this.config = config;
        }

        // GET: Car
        public ActionResult Index()
        {
            var model = mapper.Map<IEnumerable<CarViewModel>>(carService.GetCars());
            return View(model);
        }

        public JsonResult GetCarsJson()
        {
            return Json(carService.GetCars(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CarViewModel car)
        {
            if (ModelState.IsValid)
            {
                Car c = mapper.Map<Car>(car);
                carService.Create(c);
                return RedirectToAction(nameof(Index));
            }

            return View(car);
        }
    }
}