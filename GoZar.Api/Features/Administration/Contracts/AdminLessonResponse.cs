namespace GoZar.Api.Features.Administration.Contracts;
// TODO : Review editorial read models and concurrency tokens before enabling writes.
public sealed record AdminLessonResponse(Guid Id, UpsertLessonRequest Content, string RowVersion);
