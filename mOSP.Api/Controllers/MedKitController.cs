using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.MedKits;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedKitController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedKitController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}", Name = "GetMedKitWithItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<MedKitViewModel>> GetMedKitWithItem(int id)
        {
            var container = await _mediator.Send
                (new GetMedKitWithItemListQuery() { ContainerId = id });
            return Ok(container);
        }
    }
}
