using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLibrary;

namespace hw_MVCHelloMessage.Controllers
{
    public class HelloMessageController : Controller
    {
        // GET: HelloMessageController
        public ActionResult Index()
        {
            return View(new PersonModel());
        }

        [HttpPost]
        public ActionResult Submit(PersonModel model)
        {
            string helloMessage = $"Hello, {model.FirstName} {model.LastName}";
            ViewBag.Message = helloMessage;

            return View("Index", model);
        }

        // GET: HelloMessageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloMessageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloMessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloMessageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloMessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloMessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloMessageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
