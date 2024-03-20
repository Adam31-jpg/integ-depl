using Microsoft.AspNetCore.Mvc;
using ProbabilityX_API.IRepositories;
using ProbabilityX_API.IServices;
using ProbabilityX_API.Models;

namespace ProbabilityX_API.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<TodoModel>> GetAllTodos()
        {
            return await _todoRepository.GetAllTodos();
        }
        public async Task<int> AddTodo(TodoModel todo)
        {
            // Tu peux ajouter ici des règles métier ou de validation avant d'ajouter l'utilisateur
            return await _todoRepository.AddTodo(todo);
        }

        public async Task UpdateTodo(TodoModel todo)
        {
            // Tu peux ajouter ici des règles métier ou de validation avant de mettre à jour l'utilisateur
            await _todoRepository.UpdateTodo(todo);
        }

        public async Task DeleteTodo(int todoId)
        {
            // Tu peux ajouter ici des règles métier ou de validation avant de supprimer l'utilisateur
            await _todoRepository.DeleteTodo(todoId);
        }
    }
}
