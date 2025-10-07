
using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("/api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private List<User> user = new List<User>()
        {
            new User(){userId = 1, age= 24, fullName = "Ermiyas", isActive = true}
        };
        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                return Ok( new {
                    status = StatusCodes.Status200OK,
                    message = "Successfully created",
                });
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    status = "faield",
                    message = "Internal server errror"
                });                
            }
        }
    }
}

