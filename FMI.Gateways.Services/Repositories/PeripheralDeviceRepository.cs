﻿using FMI.Gateways.Data.Contexts;
using FMI.Gateways.Data.Entities;
using FMI.Gateways.Services.Repositories.Contracts;

namespace FMI.Gateways.Services.Repositories
{
    public class PeripheralDeviceRepository : RepositoryBase<PeripheralDevice>, IPeripherialDeviceRepository
    {
        public PeripheralDeviceRepository(GatewaysContext context)
            : base(context)
        {
        }
    }
}