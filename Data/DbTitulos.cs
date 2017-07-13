using CodingChallenge.Data.Classes;
using CodingChallenge.Data.DataAccess;
using System.Collections.Generic;

namespace Data
{
    /// <summary>
    /// Clase estatica que hace referencia al repositorio de los titulos.
    /// </summary>
    public class DbTitulos
    {
        private static readonly MockRepository repository = new MockRepository();

        /// <summary>
        /// Devuelve una lista con los titulos disponibles actualmente.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Titulo> GetTitulos()
        {
            return repository.TituloRepository.GetTitulos();
        }
    }
}
