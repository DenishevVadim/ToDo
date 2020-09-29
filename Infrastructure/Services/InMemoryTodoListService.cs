using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO_List.Infrastructure.Interfaces;
using TODO_List.Models.ViewModels;

namespace TODO_List.Infrastructure.Services
{
    public class InMemoryTodoListService : ITodoDataService
    {
        private readonly List<TodoItemVM> Items = new List<TodoItemVM>
        {
            new TodoItemVM()
            {
                Id = 0,
                IsExecute = true,
                Content = "Make Todo list"
            },
            new TodoItemVM()
            {
                Id = 1,
                IsExecute = false,
                Content = "Make course work"
            }
        };

        public void Add(TodoItemVM item)
        {
            Items.Add(item);
        }

        public IEnumerable<TodoItemVM> Get()
        {
            return Items;
        }

        public Task<IEnumerable<TodoItemVM>> GetAsync()
        {
            return new Task<IEnumerable<TodoItemVM>>(Get);
        }

        public bool Remove(TodoItemVM item)
        {
            return Items.Remove(item);
        }

        public bool RemoveAt(int id)
        {
            var item = Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
                return false;

            Items.Remove(item);

            return true;
        }
    }
}
