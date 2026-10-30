using System.ComponentModel.DataAnnotations;
namespace GoZar.Api.Common.Pagination;
public sealed record PageRequest([Range(1, int.MaxValue)] int Page = 1, [Range(1, 100)] int PageSize = 20);
