using Microsoft.AspNetCore.Mvc;

namespace Arguments.Base;

public class BaseController<TService> : Controller
{
    public TService? _service;

    public BaseController(TService service)
    {
        _service = service;
    }

    public async Task<ActionResult> ResponseAsync<TTypeResult, TTypeError>(BaseApiResponse<TTypeResult, TTypeError> response, string errorMessage = "Recurso não encontrado")
    {
        if (response == null || response.Result == null)
        {
            return await Task.FromResult(BadRequest(errorMessage));
        }

        return await Task.FromResult(Ok(response));
    }
}
