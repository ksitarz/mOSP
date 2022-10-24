﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class UpdateMedItemCommand : IRequest
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ContainerId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsIgnored { get; set; }
    }
}
