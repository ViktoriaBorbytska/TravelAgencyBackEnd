using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.WebApi.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsApiController : Controller
    {
        public NewsApiController(/*injecting some service*/)
        {

        }

        [HttpGet]
        [Route("getdetails/{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            return Json("");
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Json("");
        }
    }
}
