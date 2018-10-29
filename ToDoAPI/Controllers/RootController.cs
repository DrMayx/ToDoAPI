using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        private readonly ToDoContext _context;

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "wololo";
        }
    }
}