namespace lesson19_WebApi.Data.Entities
{
    public class Courses
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourses> studentCourses { get; set; }
    }
}
