﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class InventoryService : IInventoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public InventoryService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
