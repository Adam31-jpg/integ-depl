using Microsoft.AspNetCore.Mvc;
using ProbabilityX_API.IServices;
using ProbabilityX_API.Models;

namespace ProbabilityX_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var users = await _todoService.GetAllTodos();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoModel todo)
        {
            var userId = await _todoService.AddTodo(todo);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodo(int id, [FromBody] TodoModel todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }

            await _todoService.UpdateTodo(todo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            await _todoService.DeleteTodo(id);
            return NoContent();
        }
    }
}
