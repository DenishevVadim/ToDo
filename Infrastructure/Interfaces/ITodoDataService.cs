using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO_List.Models.ViewModels;

namespace TODO_List.Infrastructure.Interfaces
{
    public interface ITodoDataService
    {
        void Add(TodoItemVM item);

        IEnumerable<TodoItemVM> Get();

        Task<IEnumerable<TodoItemVM>> GetAsync();

        bool Remove(TodoItemVM item);

        bool RemoveAt(int id);
    }
}
