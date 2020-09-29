using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODO_List.Models.ViewModels
{
    public class TodoItemVM
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsExecute { get; set; }
    }
}
