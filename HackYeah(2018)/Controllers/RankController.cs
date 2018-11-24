using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HackYeah_2018_.Controllers
{
    [Route("api/Rank")]
    public class RankController : Controller
    {
        private readonly IRankService _rankService;
        public RankController(IRankService rankService)
        {
            _rankService = rankService;
        }

        [HttpGet]
        public IActionResult GetRank()
        {
            var response = _rankService.GetRank();

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
