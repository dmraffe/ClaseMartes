using System.Diagnostics.Metrics;

namespace CRUD.ENTITY.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
       
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
