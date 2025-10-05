using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;
using System.Reflection;

namespace ProfileManager.Controllers
{
    public class CountriesController : Controller
    {
        // GET: CountriesController
        public ActionResult Index()
        {
            var countries = Country.countries;
            return View(countries);
        }

        // GET: CountriesController/Details/5
        public ActionResult Details(int id)
        {
            var country = Country.countries.FirstOrDefault(p => p.Id == id);
            return View(country);
        }

        // GET: CountriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Country model)
        {
            try
            {
               model.Id = Country.countries.Max(p => p.Id) + 1;
                Country.countries.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var country = Country.countries.FirstOrDefault(p => p.Id == id);
            return View(country);
        }

        // POST: CountriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Country model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var country = Country.countries.FirstOrDefault(p => p.Id == id);
                    if (country != null)
                    {
                        country.Name = model.Name;
                        country.Code = model.Code;
                        country.Capital = model.Capital;
                        country.Region = model.Region;
                        country.Population = model.Population;
                        country.Area = model.Area;
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

        // GET: CountriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Country model)
        {
            try
            {
                var country = Country.countries.FirstOrDefault(p => p.Id == id);
                if (country != null)
                {
                    Country.countries.Remove(country);
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
