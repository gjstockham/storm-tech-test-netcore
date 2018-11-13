namespace Todo.Data.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class TodoItem
    {
        public TodoItem(int todoListId, string responsiblePartyId, string title, Importance importance)
        {
            TodoListId = todoListId;
            ResponsiblePartyId = responsiblePartyId;
            Title = title;
            Importance = importance;
        }

        protected TodoItem()
        {
        }

        public int TodoItemId { get; set; }

        public string Title { get; set; }

        public string ResponsiblePartyId { get; set; }

        public IdentityUser ResponsibleParty { get; set; }

        public bool IsDone { get; set; }

        public Importance Importance { get; set; }

        public int TodoListId { get; set; }

        public TodoList TodoList { get; set; }
    }
}