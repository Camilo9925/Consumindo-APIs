using ApiClient.Refit.Cnpj;
using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.CNPJ;
using BaseLibrary.Services;

namespace Application.Services.Cnpj;

public class CnpjService(ICnpjRefit refit) : BaseService<ICnpjRefit>(refit), ICnpjService
{
    public async Task<BaseApiResponse<OutputCnpj, string>> GetByCnpj(string cnpj)
    {
        var response = await _refit!.GetByCnpj(cnpj);
        return ReturnResponse<OutputCnpj, string>(response);
    }
}
