using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/assets")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AssetsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAssets()
        { 
            var assets = await _serviceManager.AssetService.GetAllAssetsAsync(trackChanges: false);
            return Ok(assets);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetAsset(Guid id)
        {
            var asset = await _serviceManager.AssetService.GetAssetAsync(id, trackChanges: false);
            return Ok(asset);
        }
    }
}
