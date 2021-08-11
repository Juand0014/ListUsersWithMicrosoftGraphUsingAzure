using ApiGraph.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraph.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphController : Controller
    {
        public GraphServices graphService = new GraphServices();

        [HttpGet]
        public async Task<IActionResult> GetTokenAsync()
        {
            var result = await graphService.GetAllUsers();
            return Ok(result);
        }
    }
}
