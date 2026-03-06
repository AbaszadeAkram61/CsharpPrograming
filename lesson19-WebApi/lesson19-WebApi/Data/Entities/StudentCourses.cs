namespace lesson19_WebApi.Data.Entities
{
    public class StudentCourses
    {
        public int StudentId {  get; set; }
        public int CourseId {  get; set; }
        public DateTime? StartDate {  get; set; }
        public DateTime? EndDate { get; set; }

        public Students Student {  get; set; }
        public Courses Course {  get; set; }
    }
}
