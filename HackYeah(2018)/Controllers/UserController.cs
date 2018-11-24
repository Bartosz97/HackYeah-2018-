using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Interfaces;
using HackYeah_2018_.Models;
using Microsoft.AspNetCore.Mvc;

namespace HackYeah_2018_.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService boardService)
        {
            _userService = boardService;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var response = _userService.GetUser();

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(long id)
        {
            var response = _userService.GetUserById(id);

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPut]
        public IActionResult CreateUser([FromBody] User createUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _userService.CreateUser(createUser);
            return Ok(result);
        }
    }
}
