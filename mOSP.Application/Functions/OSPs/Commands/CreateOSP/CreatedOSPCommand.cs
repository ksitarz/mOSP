﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Commands
{
    public class CreatedOSPCommand : IRequest<CreatedOSPCommandResponse>
    {
        public int OspId { get; set; }
        public string Name { get; set; }
    }
}
