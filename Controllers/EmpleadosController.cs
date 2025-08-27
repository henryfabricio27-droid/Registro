using System.Web.Mvc;

namespace Registro.Controllers
{
    public class EmpleadosController : Controller
    {
        public ActionResult Dashboard()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

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

        public ActionResult Titulos()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        public ActionResult Salarios()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }

        public ActionResult Auditoria()
        {
            if (Session["usuario"] == null) return RedirectToAction("Ingreso", "Home");
            return View();
        }
    }
}
