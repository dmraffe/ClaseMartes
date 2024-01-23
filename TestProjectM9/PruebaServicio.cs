using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ModeloModulo9;
using RepositorioModulo9;
using ServicioTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectM9
{
    [TestClass]
    public class PruebaServicio
    {
        ServicioProducto servicioProducto;

        public PruebaServicio()
        {
            
           var options = new DbContextOptionsBuilder<TestsDbContext>()
           .UseInMemoryDatabase(databaseName: $"PruebasMiercoles-{Guid.NewGuid()}")
            .Options;

            var dbcontext = new TestsDbContext(options);
            ASyncRepository<Producto> aSyncRepository = new ASyncRepository<Producto>(dbcontext);
              servicioProducto = new ServicioProducto(aSyncRepository);

        }

        [TestMethod]
        public async Task  metodoAgregarproducto()
        {

          await  servicioProducto.AddProducto(new Producto()
            {
                EsPromocion = true,
                Nombre = "Pr 1",
                Precio = 1500

            });

          await  servicioProducto.AddProducto(new Producto()
            {
                EsPromocion = false,
                Nombre = "Pr 1",
                Precio = 1500

            });
            var lista = await servicioProducto.ObtenerTodosNuevos();

            Assert.AreNotEqual(2, lista.Count);
            Assert.AreEqual(1, lista.Count);

        }
    }
}
