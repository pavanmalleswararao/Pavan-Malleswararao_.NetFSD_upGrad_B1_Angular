using Assignment1.Models;
using Assignment1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepository _repo;

        public FlightController(IFlightRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllFlights());
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(int id) 
        {
            var flight = _repo.GetFlight(id);
            if (flight != null)
            {
                return Ok(flight);
            }
            return BadRequest("Invalid Id");
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Flight flight)
        {
            _repo.AddFlight(flight);
            return RedirectToAction("GetAll");
        }
        [HttpPut("Edit")]
        public IActionResult Edit([FromBody] Flight flight) 
        {
            _repo.EditFlight(flight);
            return RedirectToAction("GetAll");
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteFlight(id);
            return RedirectToAction("GetAll");
        }
    }
}
