using ModeloModulo9;
using RepositorioModulo9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTests
{
    public class ServicioProducto
    {

        IAsyncRepositorio<Producto> asyncRepositorio;

        public ServicioProducto(IAsyncRepositorio<Producto> asyncRepositorio)
        {
            this.asyncRepositorio = asyncRepositorio;
        }


        public async Task AddProducto(Producto pr)
        {
           await  this.asyncRepositorio.AddAsync(pr);
        }


        public async Task<IReadOnlyList<Producto>> ObtenerTodos()
        {
            return await this.asyncRepositorio.GetAllAsync();
        }


        public async Task<IReadOnlyList<Producto>> ObtenerTodosNuevos()
        {
            return await this.asyncRepositorio.GetAsync(a=>a.EsPromocion);
        }
    }
}
