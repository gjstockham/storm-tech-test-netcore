namespace Todo.Models.TodoLists
{
    using System.Collections.Generic;
    using Todo.Models.TodoItems;

    public class TodoListDetailViewmodel
    {
        public TodoListDetailViewmodel(int todoListId, string title, ICollection<TodoItemSummaryViewmodel> items)
        {
            Items = items;
            TodoListId = todoListId;
            Title = title;
        }

        public int TodoListId { get; }

        public string Title { get; }

        public ICollection<TodoItemSummaryViewmodel> Items { get; }
    }
}