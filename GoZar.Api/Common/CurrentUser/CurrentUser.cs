using System.Security.Claims;
namespace GoZar.Api.Common.CurrentUser;
public sealed class CurrentUser(IHttpContextAccessor accessor) : ICurrentUser
{
    public string RequiredUserId => accessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
        ?? throw new UnauthorizedAccessException("A user identity is required.");
    // User identity is read from authenticated claims, never from an app-supplied user ID.
}
