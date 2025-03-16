using Arguments.Base;
using Newtonsoft.Json;
using Refit;

namespace BaseLibrary.Services;

public class BaseService<TRefit> : IBaseService
{
    public TRefit? _refit;

    public BaseService(TRefit refit)
    {
        _refit = refit;
    }

    public BaseApiResponse<TTypeResult, TTypeError> ReturnResponse<TTypeResult, TTypeError>(ApiResponse<string>? response)
    {
        BaseApiResponse<TTypeResult, TTypeError> baseApiResponse = new BaseApiResponse<TTypeResult, TTypeError>();
        if (response != null && response.IsSuccessStatusCode)
        {
            baseApiResponse.Result = JsonConvert.DeserializeObject<TTypeResult>(response.Content);
        }
        else
        {
            baseApiResponse.Error = JsonConvert.DeserializeObject<TTypeError>(response?.Error?.Content);
        }

        return baseApiResponse;
    }
}