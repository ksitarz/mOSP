using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class DeleteMedKitCommand : IRequest
    {
        public int ContainerId { get; set; }
    }
}
