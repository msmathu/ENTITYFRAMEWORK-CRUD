using ENTITYFRAMEWORK_CRUD.DPCONTEXT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations.Rules;

namespace ENTITYFRAMEWORK_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok  (_studentDbContext.Students.ToList());
        }

        
        

        [HttpPost]
        public async Task<IActionResult> AddStudent(AddStudentRequest addStudentRequest)
        {
            var student = new Student()
            {
                
                Name = addStudentRequest.Name,
                school = addStudentRequest.school
            };

            await  _studentDbContext.Students.AddAsync(student);
            await _studentDbContext.SaveChangesAsync();

            return Ok(student);
        }
    }
}
