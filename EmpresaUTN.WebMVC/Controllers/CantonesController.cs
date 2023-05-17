using EmpresaUTN.UAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmpresaUTN.WebMVC.Controllers
{
    public class CantonesController : Controller
    {
        private Crud<Modelos.Canton> cantones = new Crud<Modelos.Canton>();
        private string Url = "https://localhost:7264/api/cantones";

        // GET: CantonesController
        public ActionResult Index()
        {
            var datos = cantones.Select(Url);
            return View(datos);
        }

        // GET: CantonesController/Details/5
        public ActionResult Details(int id)
        {
            var datos = cantones.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: CantonesController/Create
        public ActionResult Create()
        {
            var provincias = new Crud<Modelos.Provincia>().Select(Url.Replace("cantones", "provincias"))
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Nombre
                })
                .ToList();

            ViewBag.provincias = provincias;

            return View();
        }

        // POST: CantonesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Canton datos)
        {
            try
            {
                cantones.Insert(Url, datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: CantonesController/Edit/5
        public ActionResult Edit(int id)
        {
            var provincias = new Crud<Modelos.Provincia>().Select(Url.Replace("cantones", "provincias"))
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Nombre
                })
                .ToList();

            ViewBag.provincias = provincias;

            var datos = cantones.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: CantonesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Canton datos)
        {
            try
            {
                cantones.Update(Url, id.ToString(), datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: CantonesController/Delete/5
        public ActionResult Delete(int id)
        {
            var datos = cantones.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: CantonesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Canton datos)
        {
            try
            {
                cantones.Delete(Url, id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
