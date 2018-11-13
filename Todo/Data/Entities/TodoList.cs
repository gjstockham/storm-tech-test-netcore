namespace Todo.Data.Entities
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class TodoList
    {
        public TodoList(IdentityUser owner, string title)
        {
            Owner = owner;
            Title = title;
        }

        protected TodoList()
        {
        }

        public int TodoListId { get; set; }

        public string Title { get; set; }

        public IdentityUser Owner { get; set; }

        public ICollection<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}