using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Offline.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record ContentPackAssetResponse(string RelativePath, string DownloadUrl, string Sha256, long SizeBytes);
