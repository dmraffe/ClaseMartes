using CRUD.ENTITY.Models;
using CRUD.ENTITY.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace CRUD.ENTITY.Servicio
{
    public class ServicioPersona : IServicePersonacs
    {
        private readonly CrudDbContext _context;

        public ServicioPersona(CrudDbContext context)
        {
            _context = context;

        }

        public async Task<Persona> DeletePersonaASync(int id)
        {
            var delete = await GetPersonaById(id);

            _context.Remove(delete);

            await _context.SaveChangesAsync();
            return delete;
        }

        public async Task<List<Persona>> GetAllPersonaList()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona> GetPersonaById(int id)
        {
          return  await _context.Personas.Where(a=>a.Id ==id).FirstOrDefaultAsync();
        }

        public async Task<Persona> SavePersonaASync(Persona persona)
        {
          await  _context.AddAsync(persona);
          await  _context.SaveChangesAsync();

            return persona;
        }

        public async Task<Persona> UpdatePersonaASync(Persona persona)
        {
             _context.Update(persona);
            await _context.SaveChangesAsync();
            return persona;
        }
    }

}

