namespace CRUD.ENTITY.Models
{
    public class Country
    {

        public int  Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public List<City> Cities { get; set; }
        public List<Persona> People { get; set; }

    }
}
