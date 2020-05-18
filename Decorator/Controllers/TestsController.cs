using System.Text.Json;
using System.Text.Json.Serialization;
using Decorator.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers
{
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IRepo _repo;

        public TestsController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("decorator")]
        public string Decorator()
        {
            var orderDto = _repo.Query();
            return JsonSerializer.Serialize(orderDto);
        }
    }
}