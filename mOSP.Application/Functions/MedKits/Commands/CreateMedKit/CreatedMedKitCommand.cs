using MediatR;
using mOSP.Domain.Common;
using System;
using System.Collections.Generic;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class CreatedMedKitCommand : IRequest<CreatedMedKitCommandResponse>
    {
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int OspId { get; set; }
         
        public ContainerTypes ContainerType { get; set; }
    }
}
