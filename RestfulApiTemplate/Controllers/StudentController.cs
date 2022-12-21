using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestfulApiTemplate.Data;
using RestfulApiTemplate.Models;

namespace RestfulApiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        //Get : api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetCourse()
        {
            return await _context.students.ToListAsync();
        }

      
    }
}
