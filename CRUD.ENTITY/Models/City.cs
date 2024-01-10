namespace CRUD.ENTITY.Models
{
    public class City
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Persona> People { get; set; }

    }
}
