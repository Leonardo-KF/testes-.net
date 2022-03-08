using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>();


        [HttpGet]
        public string Get()
        {
            return "okay";
        }
    }
}