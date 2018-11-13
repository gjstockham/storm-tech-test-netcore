namespace Todo.Models.TodoItems
{
    using Todo.Data.Entities;

    public class TodoItemSummaryViewmodel
    {
        public TodoItemSummaryViewmodel(int todoItemId, string title, bool isDone, UserSummaryViewmodel responsibleParty, Importance importance)
        {
            TodoItemId = todoItemId;
            Title = title;
            IsDone = isDone;
            ResponsibleParty = responsibleParty;
            Importance = importance;
        }

        public int TodoItemId { get; }

        public string Title { get; }

        public UserSummaryViewmodel ResponsibleParty { get; }

        public bool IsDone { get; }

        public Importance Importance { get; }
    }
}