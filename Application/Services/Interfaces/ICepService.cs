using Arguments.Base;
using Arguments.Entities.Cep;

namespace Application.Services.Interfaces;

public interface ICepService
{
    Task<BaseApiResponse<OutputZipCode, string>> GetByZipCode(string zipCode);
}
