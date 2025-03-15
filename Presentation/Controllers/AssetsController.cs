using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public IActionResult GetAssets()
        { 
            var assets = _serviceManager.AssetService.GetAllAssets(trackChanges: false);
            return Ok(assets);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAsset(Guid id)
        {
            var asset = _serviceManager.AssetService.GetAsset(id, trackChanges: false);
            return Ok(asset);
        }
    }
}
