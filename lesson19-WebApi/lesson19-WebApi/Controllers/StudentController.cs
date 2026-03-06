using lesson19_WebApi.Data;
using lesson19_WebApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lesson19_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private StudentsDbContext _studentdbContext;
        public StudentController(StudentsDbContext studentsDbContext)
        {
            _studentdbContext = studentsDbContext;
        }
        [HttpGet("AllStudents")]
        public async Task<object> GetStudents()
        {
            return await _studentdbContext.Students.Include(s => s.Gender).Select(s => new
            {
                s.Name,
                s.Surname,
                s.DateOfBirth,
                s.Salary,
                GenderName= s.Gender.Name,
                Courses= s.studentCourses.Select(sc => new
                {
                    sc.Course.Name,
                    sc.StartDate,
                    sc.EndDate
                })

                
            }).ToListAsync();

        }

        [HttpGet("AllStudentsReport")]
        public async Task<object> GetStudentsReports()
        {
            var query = from sc in _studentdbContext.StudentCourses
                        join s in _studentdbContext.Students on sc.StudentId equals s.Id
                        join c in _studentdbContext.Courses on sc.CourseId equals c.Id
                        select new
                        {
                            s.Name,
                            s.Surname,
                            s.DateOfBirth,
                            CourseName = c.Name,
                            sc.StartDate,
                            sc.EndDate
                        };

            return await query.ToListAsync();
        }



        [HttpGet("AllGenders")]
        public async Task<object> GetGenders()
        {
            return await _studentdbContext.Genders.Include(g => g.Students).Select(g => new
            {
                g.Name,
               students=g.Students.Select(s => new
                {
                    s.Name,
                    s.Surname,
                    s.DateOfBirth,
                    s.Salary,
                })
            }).ToListAsync();

        }
    }
}
