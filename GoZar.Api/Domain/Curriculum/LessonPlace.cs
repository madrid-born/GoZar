using GoZar.Api.Domain;
namespace GoZar.Api.Domain.Curriculum;

public sealed class LessonPlace : DomainEntity
{
    public Guid LessonId { get; set; }
    public Guid PlaceId { get; set; }
    public int Position { get; set; } = 0;
}
