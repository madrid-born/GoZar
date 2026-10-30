namespace GoZar.Api.Features.Administration.Contracts;
// TODO : Review editorial read models and concurrency tokens before enabling writes.
public sealed record AdminStoryResponse(Guid Id, UpsertStoryRequest Content, string RowVersion);
