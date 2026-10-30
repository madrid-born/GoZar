using GoZar.Api.Common.CurrentUser;
using GoZar.Api.Features.Learning.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoZar.Api.Features.Learning;

[ApiController, Authorize, Route("api/learning/today")]
public sealed class TodayController(TodayService service, ICurrentUser currentUser) : ControllerBase
{
    [HttpGet]
    public Task<TodayResponse> Get([FromQuery] Guid cityId, CancellationToken cancellationToken) =>
        service.GetAsync(currentUser.RequiredUserId, cityId, cancellationToken);
}
