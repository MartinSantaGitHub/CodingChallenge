using CodingChallenge.Data.Classes;
using Data;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using System;

namespace CodingChallenge.Controllers
{
    /// <summary>
    /// Web Api para obtener los titulos por descripcion.
    /// </summary>
    public class WebApiTitulosController : ApiController
    {
        /// <summary>
        /// Devuelve una lista de objetos con propiedades del tipo clave-valor
        /// para ser utilizados en un control de lista como por ejemplo un combo box.
        /// </summary>
        /// <param name="term">Termino para comenzar la busqueda de resultados.</param>
        /// <returns></returns>
        public IEnumerable<object> GetTitulosDescription(string term)
        {
            return DbTitulos.GetTitulos()
                 .Where(t => t.Descripcion.StartsWith(term, System.StringComparison.InvariantCultureIgnoreCase))
                 .Select(t => new { id = t.Id, name = t.Descripcion })
                 .ToList();
        }
    }
}
