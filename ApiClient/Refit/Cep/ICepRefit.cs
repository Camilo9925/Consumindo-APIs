using Refit;

namespace ApiClient.Refit.Cep;

public interface ICepRefit
{
    [Get("/api/cep/v1/{zipCode}")]
    Task<ApiResponse<string>> GetByZipCode(string zipCode);
}
