using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODO_List.Models.ViewModels
{
    public class TodoListVM
    {
        public ICollection<TodoItemVM> Todos { get; set; }
    }
}
