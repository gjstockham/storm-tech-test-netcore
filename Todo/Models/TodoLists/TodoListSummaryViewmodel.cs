namespace Todo.Models.TodoLists
{
    using Todo.Models.TodoItems;

    public class TodoListSummaryViewmodel
    {
        public TodoListSummaryViewmodel(int todoListId, string title, int numberOfNotDoneItems, UserSummaryViewmodel owner)
        {
            TodoListId = todoListId;
            Title = title;
            NumberOfNotDoneItems = numberOfNotDoneItems;
            Owner = owner;
        }

        public int TodoListId { get; }

        public string Title { get; }

        public int NumberOfNotDoneItems { get; }

        public UserSummaryViewmodel Owner { get; }
    }
}