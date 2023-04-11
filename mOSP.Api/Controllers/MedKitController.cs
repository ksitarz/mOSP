using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.MedKits;
using mOSP.Application.Functions.MedKits.Commands;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpPost(Name = "AddMedKit")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult<int>> Create([FromBody] CreatedMedKitCommand createMedKitCommand)
        {
            var result = await _mediator.Send(createMedKitCommand);
            return Ok(result.ContainerId);
        }

        [HttpPut(Name = "UpdateMedKit")]
        [Authorize(Roles = "Admin,Manager")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateMedKitCommand updateMedKitCommand)
        {
            await _mediator.Send(updateMedKitCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteMedKit")]
        [Authorize(Roles = "Admin,Manager")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteMedKitCommand = new DeleteMedKitCommand() { ContainerId = id };
            await _mediator.Send(deleteMedKitCommand);
            return NoContent();
        }
    }
}
