namespace GoZar.Api.Infrastructure.Files;

public sealed class ContentStorage
{
    public Task<string> StoreAsync(Stream content, string contentType, CancellationToken cancellationToken = default)
    {
        // TODO : Validate size/type and generate opaque server storage keys; never use a supplied filename as a filesystem path.
        throw new NotImplementedException();
    }
    public Task<Stream> OpenReadAsync(string storageKey, CancellationToken cancellationToken = default)
    {
        // TODO : Resolve storage keys safely within configured storage; authorize unpublished resources.
        throw new NotImplementedException();
    }
    public Task<Uri> GetDownloadUrlAsync(string storageKey, CancellationToken cancellationToken = default)
    {
        // TODO : Use authenticated/signed URLs when appropriate and choose expiry and caching semantics.
        throw new NotImplementedException();
    }
    public Task DeleteAsync(string storageKey, CancellationToken cancellationToken = default)
    {
        // TODO : Define retention/reference checks before deleting content in use by published packs.
        throw new NotImplementedException();
    }
}
