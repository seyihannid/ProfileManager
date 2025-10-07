using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;
using System.Reflection;

namespace ProfileManager.Controllers
{
    public class AirportsController : Controller
    {
        // GET: AirportsController
        public ActionResult Index()
        {
            var airports = Airport.airports;
            return View(airports);
        }

        // GET: AirportsController/Details/5
        public ActionResult Details(int id)
        {
            var airport = Airport.airports.FirstOrDefault(p => p.Id == id);
            return View(airport);
        }

        // GET: AirportsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AirportsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Airport model)
        {
            try
            {
                model.Id = Airport.airports.Max(p => p.Id) + 1;
                Airport.airports.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirportsController/Edit/5
        public ActionResult Edit(int id)
        {
            var airport = Airport.airports.FirstOrDefault(p => p.Id == id);
            return View(airport);
        }

        // POST: AirportsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Airport model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var airport = Airport.airports.FirstOrDefault(p => p.Id == id);
                    if (airport != null)
                    {
                        airport.Name = model.Name;
                        airport.IATA = model.IATA;
                        airport.ICAO = model.ICAO;
                        airport.City = model.City;
                        airport.Country = model.Country;
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // GET: AirportsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AirportsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var airport = Airport.airports.FirstOrDefault(p => p.Id == id);
                if (airport != null)
                {
                    Airport.airports.Remove(airport);
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
