using ApiClient.Refit.DDD;
using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.DDD;
using BaseLibrary.Services;

namespace Application.Services.DDD;

public class DddService(IDddRefit refit) : BaseService<IDddRefit>(refit), IDddService
{
    public async Task<BaseApiResponse<OutputDdd, string>> GetByDdd(int ddd)
    {
        var response = await _refit!.GetByDdd(ddd);
        return ReturnResponse<OutputDdd, string>(response);
    }
}
