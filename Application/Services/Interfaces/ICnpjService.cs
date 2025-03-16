using Arguments.Base;
using Arguments.Entities.CNPJ;

namespace Application.Services.Interfaces;

public interface ICnpjService
{
    Task<BaseApiResponse<OutputCnpj, string>> GetByCnpj(string cnpj);
}
