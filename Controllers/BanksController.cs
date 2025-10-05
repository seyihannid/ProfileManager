using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Models;

namespace ProfileManager.Controllers
{
    public class BanksController : Controller
    {
        // GET: BanksController
        public ActionResult Index()
        {
            var banks = Bank.banks;
            return View(banks);
        }

        // GET: BanksController/Details/5
        public ActionResult Details(int id)
        {
            var bank = Bank.banks.FirstOrDefault(p => p.Id == id);
            return View(bank);
        }

        // GET: BanksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BanksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bank model)
        {
            try
            {
                model.Id = Bank.banks.Max(p => p.Id) + 1;
                Bank.banks.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BanksController/Edit/5
        public ActionResult Edit(int id)
        {
            var bank = Bank.banks.FirstOrDefault(p => p.Id == id);
            return View(bank);
        }

        // POST: BanksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Bank model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var bank = Bank.banks.FirstOrDefault(p => p.Id == id);
                    if (bank != null)
                    {
                        bank.Name = model.Name;
                        bank.Code = model.Code;
                        bank.Country = model.Country;
                        bank.SWIFT = model.SWIFT;
                        bank.Address = model.Address;
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

        // GET: BanksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BanksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Bank model)
        {
            try
            {
                var bank = Bank.banks.FirstOrDefault(p => p.Id == id);
                if (bank != null)
                {
                    Bank.banks.Remove(bank);
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
