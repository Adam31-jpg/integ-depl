using ProbabilityX_API.IRepositories;
using ProbabilityX_API.Models;
using Microsoft.EntityFrameworkCore;
using ProbabilityX_API.IServices;
using ProbabilityX_API.Settings;

namespace ProbabilityX_API.Repositories
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {

        public TodoRepository(ProbabilityXContext context) : base(context)
        {
        }

        public async Task<List<TodoModel>> GetAllTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<int> AddTodo(TodoModel todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return todo.Id;
        }

        public async Task UpdateTodo(TodoModel todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTodo(int todoId)
        {
            var user = await _context.Todos.FindAsync(todoId);
            if (user != null)
            {
                _context.Todos.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
