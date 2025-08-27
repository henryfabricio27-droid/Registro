using System.Web.Mvc;

namespace Registro.Controllers
{
    public class DepartamentosController : Controller
    {
        public ActionResult Lista()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        public ActionResult Formulario()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        public ActionResult Asignacion()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        public ActionResult Gerente()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }
    }
}


