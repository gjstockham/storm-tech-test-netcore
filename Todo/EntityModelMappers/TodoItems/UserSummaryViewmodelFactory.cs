namespace Todo.EntityModelMappers.TodoItems
{
    using Microsoft.AspNetCore.Identity;
    using Todo.Models.TodoItems;

    public static class UserSummaryViewmodelFactory
    {
        public static UserSummaryViewmodel Create(IdentityUser identityUser)
        {
            return new UserSummaryViewmodel(identityUser.UserName, identityUser.Email);
        }
    }
}