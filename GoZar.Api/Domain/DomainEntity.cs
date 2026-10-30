namespace GoZar.Api.Domain;

public abstract class DomainEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTimeOffset CreatedAtUtc { get; set; }
    public DateTimeOffset UpdatedAtUtc { get; set; }
    public byte[] RowVersion { get; set; } = [];
    // TODO : Set audit timestamps using the injected TimeProvider in the write pipeline.
    // TODO : Review optimistic-concurrency tokens for imports and immutable records before generating a migration.
}
