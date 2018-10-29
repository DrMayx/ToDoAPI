using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            this._context = context;
            if (this._context.ToDoItems.Count() == 0)
            {
                this._context.ToDoItems.Add(new ToDoItem() {Name = "item1"});
                this._context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<ToDoItem>> GetAll()
        {
            return this._context.ToDoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetToDo")]
        public ActionResult<ToDoItem> GetById(long id)
        {
            var item = this._context.ToDoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}