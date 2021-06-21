using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEntityFrameworkCoreJet.Data;
using WebAPIEntityFrameworkCoreJet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIEntityFrameworkCoreJet.Controllers
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
        public async Task<ActionResult<TodoItem>> Post(TodoItem todoItem)
        {
            mContext.TodoItems.Add(todoItem);
            await mContext.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = todoItem.Id }, todoItem);
        }

        // PUT api/<TodoItemController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            mContext.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await mContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<TodoItemController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var todoItem = await mContext.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            mContext.TodoItems.Remove(todoItem);
            await mContext.SaveChangesAsync();
            return NoContent();
        }
        private bool TodoItemExists(long id)
        {
            return mContext.TodoItems.Any(e => e.Id == id);
        }
    }

}
