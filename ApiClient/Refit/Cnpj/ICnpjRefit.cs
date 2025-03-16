using Refit;

namespace ApiClient.Refit.Cnpj;

public interface ICnpjRefit
{
    [Get("/api/cnpj/v1/{cnpj}")]
    Task<ApiResponse<string>> GetByCnpj(string cnpj);
}
