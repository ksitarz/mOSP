using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.OSPs.Commands;
using mOSP.Application.Functions.OSPs.Queries;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OspController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OspController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}", Name = "GetOSPWithContainers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<OSPWithContainersViewModel>> GetOSPWithContainers(int id)
        {
            var osp = await _mediator.Send
                (new GetOSPWithMedKitListQuery() { OspId = id });
            return Ok(osp);
        }

        [HttpPost(Name = "AddOSP")]
        public async Task<ActionResult<int>> Create([FromBody] CreatedOSPCommand createOSPCommand)
        {
            var result = await _mediator.Send(createOSPCommand);
            return Ok(result.OspId);
        }

        [HttpPut(Name = "UpdateOSP")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateOSPCommand updateOSPCommand)
        {
            await _mediator.Send(updateOSPCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteOSP")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteOSPCommand = new DeleteOSPCommand() { OspId = id };
            await _mediator.Send(deleteOSPCommand);
            return NoContent();
        }
    }
}
