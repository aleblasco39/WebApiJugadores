using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiJugadores.Models;

namespace WebApiJugadores.Services
{
    interface IGenericRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        void Insert(T Obj);
        void Update(T Obj);
        Task Delete(object id);
        Task Save();

        Task<IEnumerable<Jugador>> ListaJugador();
    }
}
