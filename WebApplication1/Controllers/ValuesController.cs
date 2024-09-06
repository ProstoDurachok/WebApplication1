using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private ISRPO4Context? _db;
        public HomeController(ISRPO4Context appDBContext)
        {
            _db = appDBContext;
            if (!_db.Customers.Any())
            {
                _db.Customers.Add(new Customer {Id = 1, Name = "Tom", Number = "2" });
                _db.Customers.Add(new Customer { Name = "Alice", Number = "31" });
                _db.SaveChanges();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _db.Customers.Add(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<Customer>> Put(Customer user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (!_db.Customers.Any(x => x.Id == user.Id))
            {
                return NotFound();
            }

            _db.Update(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpGet("{id}")]
/*        [Route("/getCustomer")]
*/        public async Task<ActionResult<IEnumerable<Customer>>> Get(int id)
        {
            Customer user = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> Delete(int id)
        {
            Customer user = _db.Customers.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            _db.Customers.Remove(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }
    }
}
