using FixedAssetApp.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private static Dictionary<int,string> _assets = new Dictionary<int, string>();
        private static int _assetIndex = 0;
        private IAssetService _service;
        public AssetController(IAssetService assetService)
        {
            _service = assetService;
        }

        [HttpPost]
        [Route("addAsset")]
        public async Task<ActionResult> AddAsset(string asset)
        {
            _assetIndex++;
            _assets.Add(_assetIndex, asset);
            return Ok(_assets[_assetIndex]);
        }

        [HttpGet]
        [Route("getAsset")]
        public async Task<ActionResult> GetAsset(int id)
        {
            if(_assets.TryGetValue(id,out string value))
            {
                return Ok(value);
            }
            return Ok("no value found");
        }

        [HttpGet]
        [Route("getAllAssets")]
        public async Task<ActionResult> GetAllAssets()
        {
            return Ok(_assets.Values);
        }



    }
}
