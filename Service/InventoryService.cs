﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class InventoryService : IInventoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public InventoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper )
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
