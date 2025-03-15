using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Exceptions;
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

        public async Task<IEnumerable<AssetDto>> GetAllAssetsAsync(bool trackChanges)
        {
            var assets = await _repository.Asset.GetAllAssetsAsync(trackChanges);
            var assetsDto = _mapper.Map<IEnumerable<AssetDto>>(assets);

            return assetsDto;
        }

        public async Task<AssetDto> GetAssetAsync(Guid assetId, bool trackChanges)
        {
            var asset = await _repository.Asset.GetAssetAsync(assetId, trackChanges) ?? throw new AssetNotFoundException(assetId);
            var assetDto = _mapper.Map<AssetDto>(asset);

            return assetDto;
        }
    }
}
