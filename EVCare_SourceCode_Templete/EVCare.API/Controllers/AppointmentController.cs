using EVCare.API.Dtos;
using EVCare.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EVCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost]
        public async Task<IActionResult> BookAppointment([FromBody] BookingRequestDto request)
        {
            if (request == null || string.IsNullOrEmpty(request.Description))
            {
                return BadRequest("Invalid scheduling data.");
            }

            var result = await _appointmentService.CreateAndAutoAssignAsync(
                request.ScheduledTime,
                request.Description,
                request.SkillRequired
            );

            return Ok(new
            {
                Message = "Appointment booking processed successfully!",
                Data = result
            });
        }
    }
}
