using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.WebApi.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ReviewApiController : Controller
    {
        public ReviewApiController(/*injecting some service*/)
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
