namespace WebProject.Infrastructure.Extensions
{
    using System.Security.Claims;

    using static Common.DataConstants.DataConstants.Admin;

    public static class ClaimsPrincipalExtentions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }
    }
}
