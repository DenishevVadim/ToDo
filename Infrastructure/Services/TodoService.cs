using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO_List.Infrastructure.Interfaces;
using TODO_List.Models.ViewModels;

namespace TODO_List.Infrastructure.Services
{
    public class TodoService
    {
        private readonly ITodoDataService _todoDataService;

        public TodoService(ITodoDataService todoService)
        {
            _todoDataService = todoService;
        }

        public void Add(TodoItemVM item)
        {
            _todoDataService.Add(item);
        }

        public IEnumerable<TodoItemVM> Get()
        {
            return _todoDataService.Get();
        }

        public Task<IEnumerable<TodoItemVM>> GetAsync()
        {
            return _todoDataService.GetAsync();
        }

        public bool Remove(TodoItemVM item)
        {
            return _todoDataService.Remove(item);
        }

        public bool RemoveAt(int id)
        {
            return _todoDataService.RemoveAt(id);
        }
    }
}
