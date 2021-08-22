using GeoCubed.Minimiez.Application.Features.Welcome.Queries.WelcomeMessage;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.SupermiezApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WelcomeController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet(Name = "Welcome")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<string>> Welcome()
        {
            var message = await this._mediator.Send(new WelcomeMessageQuery());
            return Ok(message);
        }
    }
}
