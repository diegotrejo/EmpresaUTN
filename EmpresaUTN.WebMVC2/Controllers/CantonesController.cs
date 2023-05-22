using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpresaUTN.UAPI;
using EmpresaUTN.Modelos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmpresaUTN.WebMVC2.Controllers
{
    public class CantonesController : Controller
    {
        private string Url = "https://localhost:7264/api/Cantones";
        private Crud<Canton> Crud { get; set; }

        public CantonesController()
        {
            Crud = new Crud<Canton>();
        }

        // GET: CantonesController
        public ActionResult Index()
        {
            var datos = Crud.Select(Url);
            return View(datos);
        }

        // GET: CantonesController/Details/5
        public ActionResult Details(int id)
        {
            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: CantonesController/Create
        public ActionResult Create()
        {
            // obtenemos la lista de provincias para que sea usada en la Vista en un ComboBox
            var listaProvincias = new Crud<Provincia>()
                .Select(Url.Replace("Cantones", "Provincias"))
                .Select(p => new SelectListItem     // transformamos del tipo Privincia -> SelectListItem
                {
                     Value = p.Id.ToString(),       // codigo de provincia
                     Text = p.Nombre                // nombre de provincia
                 })
                .ToList();

            ViewBag.ListaProvincias = listaProvincias;  // pasamos la lista de Provincias a la vista

            return View();
        }

        // POST: CantonesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Canton datos)
        {
            try
            {
                Crud.Insert(Url, datos);
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
            // obtenemos la lista de provincias para que sea usada en la Vista en un ComboBox
            var listaProvincias = new Crud<Provincia>()
                .Select(Url.Replace("Cantones", "Provincias"))
                .Select(p => new SelectListItem     // transformamos del tipo Privincia -> SelectListItem
                {
                    Value = p.Id.ToString(),       // codigo de provincia
                    Text = p.Nombre                // nombre de provincia
                })
                .ToList();

            ViewBag.ListaProvincias = listaProvincias;  // pasamos la lista de Provincias a la vista

            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: CantonesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Canton datos)
        {
            try
            {
                Crud.Update(Url, id.ToString(), datos);
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
            var datos = Crud.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: CantonesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Canton datos)
        {
            try
            {
                Crud.Delete(Url, id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
