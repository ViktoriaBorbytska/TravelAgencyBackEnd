using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.WebApi.Controllers
{
    [Route("api/offers")]
    [ApiController]
    public class OfferApiController : Controller
    {
        public OfferApiController(/*injecting some service*/)
        {

        }

        [HttpGet]
        [Route("gettop")]
        public async Task<IActionResult> GetTop()
        {
            return Json("");
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
