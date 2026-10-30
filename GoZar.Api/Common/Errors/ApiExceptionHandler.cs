using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace GoZar.Api.Common.Errors;

public sealed class ApiExceptionHandler(IProblemDetailsService problems) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is not (NotImplementedException or UnauthorizedAccessException)) return false;
        var status = exception is NotImplementedException ? StatusCodes.Status501NotImplemented : StatusCodes.Status401Unauthorized;
        context.Response.StatusCode = status;
        await problems.WriteAsync(new ProblemDetailsContext
        {
            HttpContext = context,
            ProblemDetails = new ProblemDetails
            {
                Status = status,
                Title = status == 501 ? "Operation not implemented" : "Authentication required",
                Detail = status == 501 ? "This endpoint is scaffolded. Its service operation has not been implemented yet." : "A valid user identity is required.",
                Extensions = { ["traceId"] = context.TraceIdentifier }
            }
        });
        return true;
    }
}
