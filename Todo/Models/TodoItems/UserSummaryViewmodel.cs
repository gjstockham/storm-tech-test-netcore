namespace Todo.Models.TodoItems
{
    public class UserSummaryViewmodel
    {
        public UserSummaryViewmodel(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        public string UserName { get; }

        public string Email { get; }
    }
}