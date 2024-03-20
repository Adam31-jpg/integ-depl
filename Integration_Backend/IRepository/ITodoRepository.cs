using ProbabilityX_API.Models;

namespace ProbabilityX_API.IRepositories
{
    public interface ITodoRepository
    {
        Task<List<TodoModel>> GetAllTodos();
        Task<int> AddTodo(TodoModel todo);
        Task UpdateTodo(TodoModel todo);
        Task DeleteTodo(int todoId);
    }
}
