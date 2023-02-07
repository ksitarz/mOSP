using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.Roles.Commands;
using mOSP.Application.Functions.Users.Commands.CreateUser;
using mOSP.Application.Functions.Users.Queries.LoginUser;
using System.Threading.Tasks;

namespace mOSP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Login")]
        public ActionResult Login([FromBody] LoginUserQuery loginUserQuery)
        {
            var token = _mediator.Send(loginUserQuery);
            return Ok(token);

        }

        [HttpPost(Name = "AddUser")]
        public async Task<ActionResult<int>> Create([FromBody] CreatedUserCommand createUserCommand)
        {
            var result = await _mediator.Send(createUserCommand);
            return Ok(result.UserId);
        }
    }
}
