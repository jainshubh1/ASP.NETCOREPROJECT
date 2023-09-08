using System.Security.Claims;

namespace RunGroupWebApp
{
    public static class ClaimsPrincpalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
