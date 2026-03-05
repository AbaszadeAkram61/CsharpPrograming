
using lesson18_WepApI.Data;
using lesson18_WepApI.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lesson18_WepApI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentdbContext _studentdbcontext;
        public StudentController(StudentdbContext studentdbContext)
        {
            _studentdbcontext = studentdbContext;
        }

        [HttpGet("AllStudents")]
        public async Task< List<Students>> GetStudents()
        {
           return await _studentdbcontext.Students.ToListAsync();
        }

        [HttpPost("Create")]
        public async Task<List<Students>> CreateStudents(Students students)
        {
           await _studentdbcontext.Students.AddAsync(students);
           await _studentdbcontext.SaveChangesAsync();

           return await _studentdbcontext.Students.ToListAsync();
        }

        [HttpPut("Update")]
        public async Task<Students> UpdateStudent(int id,Students newstudents)
        {
          var student= await _studentdbcontext.Students.FirstOrDefaultAsync(x => x.Id == id);
            student.Name = newstudents.Name;
            await _studentdbcontext.SaveChangesAsync();

            return newstudents;
        }

        [HttpDelete("Delete")]
        public async Task<List<Students>> DeleteStudents(int id)
        {
           var student=await _studentdbcontext.Students.FirstOrDefaultAsync(x => x.Id == id);
            _studentdbcontext.Students.Remove(student);
           await _studentdbcontext.SaveChangesAsync();

            return await _studentdbcontext.Students.ToListAsync();

        }

       
    }
}
