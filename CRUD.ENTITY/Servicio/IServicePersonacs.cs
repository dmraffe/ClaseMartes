using CRUD.ENTITY.Models;

namespace CRUD.ENTITY.Servicio
{
    public interface IServicePersonacs
    {

        public Task<Persona> SavePersonaASync(Persona persona);
        public Task<Persona> UpdatePersonaASync(Persona persona);

        public Task<Persona> DeletePersonaASync(int id);

        public Task<Persona> GetPersonaById(int id);

        public Task<List<Persona>>  GetAllPersonaList();

    }
}
