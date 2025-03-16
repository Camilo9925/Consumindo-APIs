using ApiClient.Refit.Cep;
using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.Cep;
using BaseLibrary.Services;

namespace Application.Services.Cep;
public class CepService(ICepRefit refit) : BaseService<ICepRefit>(refit), ICepService
{
    public async Task<BaseApiResponse<OutputZipCode, string>> GetByZipCode(string zipCode)
    {
        var response = await _refit!.GetByZipCode(zipCode);
        return ReturnResponse<OutputZipCode, string>(response);
    }
}
