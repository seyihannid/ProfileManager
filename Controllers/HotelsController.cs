using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;

namespace ProfileManager.Controllers
{
    public class HotelsController : Controller
    {
        // GET: HotelsController
        public ActionResult Index()
        {
            var hotels = Hotel.hotels;
            return View(hotels);
        }

        // GET: HotelsController/Details/5
        public ActionResult Details(int id)
        {
            var hotel = Hotel.hotels.FirstOrDefault(p => p.Id == id);
            return View(hotel);
        }

        // GET: HotelsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hotel model)
        {
            try
            {
                model.Id = Hotel.hotels.Max(p => p.Id) + 1;
                Hotel.hotels.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelsController/Edit/5
        public ActionResult Edit(int id)
        {
            var hotel = Hotel.hotels.FirstOrDefault(p => p.Id == id);
            return View(hotel);
        }

        // POST: HotelsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hotel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existingHotel = Hotel.hotels.FirstOrDefault(p => p.Id == id);
                    if (existingHotel != null)
                    {
                        existingHotel.Name = model.Name;
                        existingHotel.Location = model.Location;
                        existingHotel.Rating = model.Rating;
                        existingHotel.Amenities = model.Amenities;
                        existingHotel.PricePerNight = model.PricePerNight;
                    }
                    return RedirectToAction(nameof(Index));
                }
            
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotelsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var hotel = Hotel.hotels.FirstOrDefault(p => p.Id == id);
                if (hotel != null)
                {
                    Hotel.hotels.Remove(hotel);
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
