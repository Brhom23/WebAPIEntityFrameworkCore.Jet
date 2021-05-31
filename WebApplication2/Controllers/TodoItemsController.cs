using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        public readonly Context_MSAccess mContext;
        public TodoItemsController(Context_MSAccess pContext)
        {
            mContext = pContext;
        }

        // GET: api/<TodoItemController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> Get()
        {
            return await mContext.TodoItems.ToListAsync();

            //return new string[] { "value1", "value2", mContext.TodoItems.Count().ToString() };
            //return new string[] { "value1", "value2" };
        }

        // GET api/<TodoItemController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> Get(long id)
        {
            var todoItem = await mContext.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
            //return "value";
        }

        // POST api/<TodoItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
