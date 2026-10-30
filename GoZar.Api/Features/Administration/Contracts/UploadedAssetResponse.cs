namespace GoZar.Api.Features.Administration.Contracts;
public sealed record UploadedAssetResponse(string StorageKey, long SizeBytes, string ContentType);
// TODO : Decide permitted upload types, maximum size, scanning and retention before enabling this contract.
