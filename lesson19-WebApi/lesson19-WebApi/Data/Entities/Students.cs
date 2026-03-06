using System.ComponentModel.DataAnnotations;

namespace lesson19_WebApi.Data.Entities
{
    public class Students
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        public DateTime DateOfBirth{  get; set; }
        public int? Salary {  get; set; }
        public int? GenderId { get; set; }

        public Genders Gender { get; set; }

        public ICollection<StudentCourses> studentCourses {  get; set; }
    }
}
