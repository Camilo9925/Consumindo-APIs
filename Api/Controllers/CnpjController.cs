using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.CNPJ;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class CnpjController(ICnpjService service) : BaseController<ICnpjService>(service)
    {
        [ProducesResponseType<OutputCnpj>(StatusCodes.Status200OK)]
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<BaseApiResponse<OutputCnpj, string>>> GetByCnpj(string cnpj)
        {
            try
            {
                return await ResponseAsync(await _service!.GetByCnpj(cnpj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}