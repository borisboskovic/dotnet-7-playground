using dotnet_7_playground.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_7_playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ExampleController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public IActionResult GetAll()
        {
            var items = _db.Examples.ToList();
            return Ok(items);
        }
    }
}
