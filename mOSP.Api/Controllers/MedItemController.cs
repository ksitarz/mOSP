using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mOSP.Application.Functions.MedItems;
using System.Collections.Generic;
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

       
    }
}
