using System.ComponentModel.DataAnnotations;
using System.Text.Json;
namespace GoZar.Api.Features.Offline.Contracts;

// TODO : Review this proposed contract before connecting MAUI or publishing API compatibility guarantees.
public sealed record ContentPackManifestResponse(Guid PackId, Guid CityId, int Version, long SizeBytes, string Sha256, IReadOnlyList<ContentPackAssetResponse> Assets);
