﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class AssetService : IAssetService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public AssetService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<AssetDto> GetAllAssets(bool trackChanges)
        {
            var assets = _repository.Asset.GetAllAssets(trackChanges);
            var assetsDto = _mapper.Map<IEnumerable<AssetDto>>(assets);

            return assetsDto;
        }
    }
}
