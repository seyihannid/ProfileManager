using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;
using System.Reflection;

namespace ProfileManager.Controllers
{
    public class Cars : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var cars = Car.cars;
            return View(cars);
        }

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            var car = Car.cars.FirstOrDefault(p => p.Id == id);
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                car.Id = Car.cars.Max(p => p.Id) + 1;
                Car.cars.Add(car);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            var car = Car.cars.FirstOrDefault(p => p.Id == id);
            return View(car);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car car)
            {
            try
            {
                var existingCar = Car.cars.FirstOrDefault(p => p.Id == id);
                if (existingCar != null)
                {
                    existingCar.Make = car.Make;
                    existingCar.Model = car.Model;
                    existingCar.Year = car.Year;
                    existingCar.Color = car.Color;
                    existingCar.VIN = car.VIN;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }   
        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var car = Car.cars.FirstOrDefault(p => p.Id == id);
                if (car != null)
                {
                    Car.cars.Remove(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
