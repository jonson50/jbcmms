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
            try
            {
                var assets = _serviceManager.AssetService.GetAllAssets(trackChanges: false);
                return Ok(assets);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
