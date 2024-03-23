using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace SM.Clone.Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetUser()
        {
            return Ok("Successfully");
        }
    }
}