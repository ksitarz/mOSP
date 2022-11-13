using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.MedItems.Commands;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddMedItem")]
        public async Task<ActionResult<int>> Create([FromBody] CreatedMedItemCommand createMedItemCommand)
        {
            var result = await _mediator.Send(createMedItemCommand);
            return Ok(result.ItemId);
        }

        [HttpPut(Name = "UpdateMedItem")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateMedItemCommand updateMedItemCommand)
        {
            await _mediator.Send(updateMedItemCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteMedItem")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteMedItemCommand = new DeleteMedItemCommand() { ItemId = id };
            await _mediator.Send(deleteMedItemCommand);
            return NoContent();
        }
    }
}
