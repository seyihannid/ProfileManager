using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;

namespace ProfileManager.Controllers
{
    public class ProfilesController : Controller
    {
        // GET: ProfilesController
        public ActionResult Index()
        {
            var profiles = Profile.profiles;
            return View(profiles);
        }

        // GET: ProfilesController/Details/5
        public ActionResult Details(int id)
        {
            var profile = Profile.profiles.FirstOrDefault(p => p.Id == id);
            return View(profile);
        }

        // GET: ProfilesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfilesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profile model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = Profile.profiles.Max(p => p.Id) + 1;
                    Profile.profiles.Add(model);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfilesController/Edit/5
        public ActionResult Edit(int id)
        {
            var profile = Profile.profiles.FirstOrDefault(p => p.Id == id);
            return View(profile);
        }

        // POST: ProfilesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Profile model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var profile = Profile.profiles.FirstOrDefault(p => p.Id == id);
                    if (profile != null)
                    {
                        profile.FirstName = model.FirstName;
                        profile.LastName = model.LastName;
                        profile.Email = model.Email;
                        profile.Phone = model.Phone;
                        profile.Address = model.Address;
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

        // GET: ProfilesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfilesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Profile model)
        {
            try
            {
                var profile = Profile.profiles.FirstOrDefault(p => p.Id == id);
                if (profile != null)
                {
                    Profile.profiles.Remove(profile);
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