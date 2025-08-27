using System.Web.Mvc;

namespace Registro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ingreso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(string correo, string clave)
        {
            if (correo == "admin@correo.com" && clave == "123456")
            {
                Session["usuario"] = correo;
                return RedirectToAction("Menu");
            }
            else
            {
                ViewBag.Error = "Usuario o clave incorrectos";
                return View("Ingreso");
            }
        }

        public ActionResult Menu()
        {
            if (Session["usuario"] == null)
                return RedirectToAction("Ingreso");

            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear(); // Limpiar sesión
            return RedirectToAction("Ingreso");
        }

    }
}

