namespace GoZar.Api.Features.Administration.Contracts;
// TODO : Review editorial read models and concurrency tokens before enabling writes.
public sealed record AdminFactResponse(Guid Id, UpsertFactRequest Content, string RowVersion);
