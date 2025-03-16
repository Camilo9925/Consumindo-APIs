using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.Cep;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("[controller]")]
public class CepController(ICepService service) : BaseController<ICepService>(service)
{
    [ProducesResponseType<OutputZipCode>(StatusCodes.Status200OK)]    
    [HttpGet("{zipCode}")]
    public async Task<ActionResult<BaseApiResponse<OutputZipCode, string>>> GetByZipCode(string zipCode)
    {
        try
        {
            return await ResponseAsync(await _service!.GetByZipCode(zipCode));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
