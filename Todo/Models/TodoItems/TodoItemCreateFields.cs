namespace Todo.Models.TodoItems
{
    using Todo.Data.Entities;

    public class TodoItemCreateFields
    {
        public TodoItemCreateFields()
        {
        }

        public TodoItemCreateFields(int todoListId, string todoListTitle, string responsiblePartyId)
        {
            TodoListId = todoListId;
            TodoListTitle = todoListTitle;
            ResponsiblePartyId = responsiblePartyId;
        }

        public int TodoListId { get; set; }

        public string Title { get; set; }

        public string TodoListTitle { get; set; }

        public string ResponsiblePartyId { get; set; }

        public Importance Importance { get; set; } = Importance.Medium;
    }
}