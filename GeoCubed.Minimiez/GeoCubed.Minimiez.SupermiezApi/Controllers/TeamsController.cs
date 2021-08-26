using GeoCubed.Minimiez.Application.Features.Teams.GetAllTeams;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.SupermiezApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        /* TODO: this is for getting the teams registered for the upcomming tourney
         * -> GetTeams (get teams /w players and their checkin status)
         */

        private readonly IMediator _mediator;

        public TeamsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllParticipants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TeamVm>>> GetAllParticipants()
        {
            var teams = await this._mediator.Send(new GetAllTeamsQuery());
            return Ok(teams);
        }
    }
}
