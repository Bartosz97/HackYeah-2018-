using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Interfaces;
using HackYeah_2018_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace HackYeah_2018_.Controllers
{
    [Route("api/Ticket")]
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public IActionResult GetTickets()
        {
            var response = _ticketService.GetTickets();

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetTicketById(long id)
        {
            var response = _ticketService.GetTicketById(id);

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPut]
        public IActionResult AddTicket([FromBody] Ticket addTicket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _ticketService.AddTicket(addTicket);
            return Ok(result);
        }
    }
}
