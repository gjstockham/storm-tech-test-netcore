namespace Todo.Models.TodoLists
{
    using System.Collections.Generic;

    public class TodoListIndexViewmodel
    {
        public TodoListIndexViewmodel(ICollection<TodoListSummaryViewmodel> lists)
        {
            Lists = lists;
        }

        public ICollection<TodoListSummaryViewmodel> Lists { get; }
    }
}