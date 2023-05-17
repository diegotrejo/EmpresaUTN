using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpresaUTN.UAPI;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmpresaUTN.WebMVC.Controllers
{
    public class ProvinciasController : Controller
    {
        private Crud<Modelos.Provincia> provincias = new Crud<Modelos.Provincia>();
        private string Url = "https://localhost:7264/api/provincias";

        // GET: ProvinciasController
        public ActionResult Index()
        {
            var datos = provincias.Select(Url);
            return View(datos);
        }

        // GET: ProvinciasController/Details/5
        public ActionResult Details(int id)
        {
            var datos = provincias.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: ProvinciasController/Create
        public ActionResult Create()
        {
            var paises = new Crud<Modelos.Pais>().Select(Url.Replace("provincias", "paises"))
                .Select(p => new SelectListItem
                {
                    Value = p.CodigoPais.ToString(),
                    Text = p.Nombre
                })
                .ToList();

            ViewBag.paises = paises;

            return View();
        }

        // POST: ProvinciasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Provincia datos)
        {
            try
            {
                provincias.Insert(Url, datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProvinciasController/Edit/5
        public ActionResult Edit(int id)
        {
            var paises = new Crud<Modelos.Pais>().Select(Url.Replace("provincias", "paises"))
                .Select(p => new SelectListItem
                {
                    Value = p.CodigoPais.ToString(),
                    Text = p.Nombre
                })
                .ToList();

            ViewBag.paises = paises;

            var datos = provincias.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: ProvinciasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Provincia datos)
        {
            try
            {
                provincias.Update(Url, id.ToString(), datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: ProvinciasController/Delete/5
        public ActionResult Delete(int id)
        {
            var datos = provincias.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: ProvinciasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Provincia datos)
        {
            try
            {
                provincias.Delete(Url, id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
