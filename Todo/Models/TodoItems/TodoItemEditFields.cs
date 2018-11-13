namespace Todo.Models.TodoItems
{
    using Todo.Data.Entities;

    public class TodoItemEditFields
    {
        public TodoItemEditFields()
        {
        }

        public TodoItemEditFields(int todoListId, string todoListTitle, int todoItemId, string title, bool isDone, string responsiblePartyId, Importance importance)
        {
            TodoListId = todoListId;
            TodoListTitle = todoListTitle;
            TodoItemId = todoItemId;
            Title = title;
            IsDone = isDone;
            ResponsiblePartyId = responsiblePartyId;
            Importance = Importance.Medium;
        }

        public int TodoListId { get; set; }

        public string Title { get; set; }

        public string TodoListTitle { get; set; }

        public int TodoItemId { get; set; }

        public bool IsDone { get; set; }

        public string ResponsiblePartyId { get; set; }

        public Importance Importance { get; set; }
    }
}