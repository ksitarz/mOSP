using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.OSPs.Commands;
using mOSP.Application.Functions.OSPs.Queries;
using mOSP.Application.Functions.Roles.Commands;
using mOSP.Application.Functions.Roles.Queries;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator= mediator;
        }

        [HttpGet("{id}", Name = "GetRoleById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<RoleViewModel>> GetRoleById(int id)
        {
            var role = await _mediator.Send
                (new GetRoleQuery() { RoleId = id });
            return Ok(role);
        }

        [HttpGet(Name = "GetAllRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<RoleViewModel>> GetAllRoles()
        {
            var role = await _mediator.Send
                (new GetAllRoleQuery());
            return Ok(role);
        }

        [HttpPost(Name = "AddRole")]
        public async Task<ActionResult<int>> Create([FromBody] CreatedRoleCommand createRoleCommand)
        {
            var result = await _mediator.Send(createRoleCommand);
            return Ok(result.RoleId);
        }

        [HttpPut(Name = "UpdateRole")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateRoleCommand updateRoleCommand)
        {
            await _mediator.Send(updateRoleCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteRole")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteRoleCommand = new DeleteRoleCommand() { RoleId = id };
            await _mediator.Send(deleteRoleCommand);
            return NoContent();
        }
    }
}
