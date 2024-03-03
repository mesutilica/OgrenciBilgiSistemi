using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiSistemi.Data;
using OgrenciBilgiSistemi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OgrenciBilgiSistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public StudentsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var kayit = _context.Students.Find(id);
            if (kayit == null)
                return NotFound();
            return Ok(kayit);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public IActionResult Post([FromBody] Student value) // FromForm
        {
            _context.Students.Add(value);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student value)
        {
            _context.Students.Update(value);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var kayit = _context.Students.Find(id);
            if (kayit != null)
            {
                _context.Students.Remove(kayit);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
