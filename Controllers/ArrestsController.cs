using Microsoft.AspNetCore.Mvc;
using ArrestTracker.Models;
using ArrestTracker.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArrestTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrestsController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public ArrestsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<ArrestsController>
        [HttpGet]
        public   IEnumerable<Students> GetAllStudents()
        {
            //return new string[] { "value1", "value2" };
            var students =  _context.Students.ToList();

            return students;
        }

        // GET api/<ArrestsController>/5
        [HttpGet("{id}")]
        public string GetStudentById(int id)
        {
            return "value";
        }

        // POST api/<ArrestsController>
        [HttpPost]
        public void Post([FromBody] Students model)
        {
            _context.Students.Add(model); 
            _context.SaveChanges();
              
        }

        // PUT api/<ArrestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArrestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
