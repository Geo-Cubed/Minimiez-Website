using GeoCubed.Minimiez.Application.Features.Groups.GetGroups;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.SupermiezApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllGroups")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GroupsVm>>> GetGroups()
        {
            var groups = await this._mediator.Send(new GetGroupsQuery());
            return Ok(groups);
        }
    }
}
