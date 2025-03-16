using Application.Services.Interfaces;
using Arguments.Base;
using Arguments.Entities.DDD;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DddController(IDddService service) : BaseController<IDddService>(service)
    {
        [ProducesResponseType<OutputDdd>(StatusCodes.Status200OK)]
        [HttpGet("{ddd}")]
        public async Task<ActionResult<BaseApiResponse<OutputDdd, string>>> GetByDdd(int ddd)
        {
            try
            {
                return await ResponseAsync(await _service!.GetByDdd(ddd));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}