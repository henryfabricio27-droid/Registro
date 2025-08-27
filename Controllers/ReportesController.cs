using System.Web.Mvc;

namespace Registro.Controllers
{
    public class ReportesController : Controller
    {
        public ActionResult Index()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        [HttpPost]
        public ActionResult Generar(string dept_no, string fechaInicio, string fechaFin)
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");

            ViewBag.DeptNo = dept_no;
            ViewBag.FechaInicio = fechaInicio;
            ViewBag.FechaFin = fechaFin;

            return View("Index");
        }
    }
}

