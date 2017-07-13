using CodingChallenge.Data.Classes;
using Data;
using System.Linq;
using System.Web.Mvc;

namespace CodingChallenge.Controllers
{
    /// <summary>
    /// Controlador principal para el manejo de las vistas y datos del aplicativo.
    /// </summary>
    public class TitulosController : Controller
    {
        /// <summary>
        /// Retorna la vista principal index del aplicativo.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Devuelve una partial view con los datos de un titulo recuperado por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PartialViewResult GetTitulo(int id)
        {
            var titulo = DbTitulos.GetTitulos()
                 .Where(t => t.Id == id)
                 .Select(t => t)
                 .FirstOrDefault();

            return PartialView("_GetTituloPartialView", titulo);
        }
    }
}