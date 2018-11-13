namespace Todo.EntityModelMappers.TodoItems
{
    using Todo.Data.Entities;
    using Todo.Models.TodoItems;

    public static class TodoItemCreateFieldsFactory
    {
        public static TodoItemCreateFields Create(TodoList todoList, string defaultResponsibleUserId)
        {
            return new TodoItemCreateFields(todoList.TodoListId, todoList.Title, defaultResponsibleUserId);
        }
    }
}