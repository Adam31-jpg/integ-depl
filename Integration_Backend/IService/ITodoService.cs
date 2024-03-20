using Microsoft.AspNetCore.Mvc;
using ProbabilityX_API.Models;

namespace ProbabilityX_API.IServices
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetAllTodos();
        Task<int> AddTodo(TodoModel todo);
        Task UpdateTodo(TodoModel todo);
        Task DeleteTodo(int todoId);
    }
}
