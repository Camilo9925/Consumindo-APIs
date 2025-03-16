using Refit;

namespace ApiClient.Refit.DDD;

public interface IDddRefit
{
    [Get("/api/ddd/v1/{ddd}")]
    Task<ApiResponse<string>> GetByDdd(int ddd);
}
