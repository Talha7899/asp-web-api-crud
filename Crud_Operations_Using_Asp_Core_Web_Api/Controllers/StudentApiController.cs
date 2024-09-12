using Crud_Operations_Using_Asp_Core_Web_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operations_Using_Asp_Core_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly ApiCrudContext db;

        public StudentApiController(ApiCrudContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await db.Students.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Student>> GetStudentById(int Id)
        {
            var student = await db.Students.FindAsync(Id);
            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student std)
        {
            await db.Students.AddAsync(std);
            await db.SaveChangesAsync();
            return Ok(std);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<Student>> UpdateStudent(int Id, Student std)
        {
            if (Id != std.Id)
            {
                return BadRequest();
            }

          db.Entry(std).State = EntityState.Modified;
          await db.SaveChangesAsync();
          return Ok(std);
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int Id)
        {
            var std = await db.Students.FindAsync(Id);
            if (std == null)
            {
                return NotFound();
            }

            db.Students.Remove(std);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
