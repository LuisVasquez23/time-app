using Microsoft.AspNetCore.Mvc;

namespace TimerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        [HttpGet("today")]
        public IActionResult GetToday()
        {
            var today = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            return Ok(new { date = today });
        }
    }
}
