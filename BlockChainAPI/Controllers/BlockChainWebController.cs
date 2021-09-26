using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockChainAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlockChainWebController : ControllerBase
    {

        private readonly ILogger<BlockChainWebController> _logger;

        public BlockChainWebController(ILogger<BlockChainWebController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Index()
        {
            
        }
    }
}
