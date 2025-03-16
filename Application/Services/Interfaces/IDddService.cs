using Arguments.Base;
using Arguments.Entities.DDD;

namespace Application.Services.Interfaces;

public interface IDddService
{
    Task<BaseApiResponse<OutputDdd, string>> GetByDdd(int ddd);
}
