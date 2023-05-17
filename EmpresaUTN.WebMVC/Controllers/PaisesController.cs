using EmpresaUTN.UAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaUTN.WebMVC.Controllers
{
    public class PaisesController : Controller
    {
        private Crud<Modelos.Pais> paises = new Crud<Modelos.Pais>();
        private string Url = "https://localhost:7264/api/paises";


        // GET: PaisesController1
        public ActionResult Index()
        {
            var datos = paises.Select(Url);
            return View(datos);
        }

        // GET: PaisesController1/Details/5
        public ActionResult Details(int id)
        {
            var datos = paises.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: PaisesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaisesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelos.Pais datos)
        {
            try
            {
                paises.Insert(Url, datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: PaisesController1/Edit/5
        public ActionResult Edit(int id)
        {
            var datos = paises.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: PaisesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelos.Pais datos)
        {
            try
            {
                paises.Update(Url, id.ToString(), datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: PaisesController1/Delete/5
        public ActionResult Delete(int id)
        {
            var datos = paises.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: PaisesController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Modelos.Pais datos)
        {
            try
            {
                paises.Delete(Url, id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
