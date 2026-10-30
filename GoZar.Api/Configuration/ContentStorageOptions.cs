namespace GoZar.Api.Configuration;
public sealed class ContentStorageOptions
{
    public string? RootPath { get; set; }
    // TODO : Choose local/object storage, download URL lifetime, limits and retention before enabling uploads.
}
