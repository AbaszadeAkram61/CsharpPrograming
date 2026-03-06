namespace lesson19_WebApi.Data.Entities
{
    public class Genders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Students> Students { get; set; }
    }
}
