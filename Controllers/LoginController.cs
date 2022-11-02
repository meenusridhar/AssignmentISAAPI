using AssignmentISAAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentISAAPI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IJWTAuthenticateManager jWTAuthenticateManager;

        public LoginController(IJWTAuthenticateManager jWTAuthenticateManager)
        {
            this.jWTAuthenticateManager = jWTAuthenticateManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCredentials userCredentials)
        {
            var token = jWTAuthenticateManager.Authenticate(userCredentials.UserName, userCredentials.Password);
            return Ok(token);
        }
    }
}
