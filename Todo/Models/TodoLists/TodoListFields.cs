namespace Todo.Models.TodoLists
{
    using System.ComponentModel.DataAnnotations;

    public class TodoListFields
    {
        [Required]
        public string Title { get; set; }
    }
}