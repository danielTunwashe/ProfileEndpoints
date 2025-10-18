using Application.Profiles.Queries.GetMe;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using profileEndpoint.Application.Queries.GetMe;
using profileEndpoint.Domain.Models.Dto;

namespace profileEndpoint.Controllers
{
    [Route("api/me")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ProfileOutput>> GetMe()
        {
            var myProfiles = await _mediator.Send(new GetMeQuery());
            return Ok(myProfiles);
        }

    }
}
