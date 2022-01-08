using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.API.Hubs;
using System.Threading.Tasks;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IHubContext<MyHub> _hunContext;

        public NotificationController(IHubContext<MyHub> hunContext)
        {
            _hunContext = hunContext;
        }

        [HttpGet("{teamCount}")]
        public async Task<IActionResult> SetTeamCount(int teamCount)
        {
            MyHub.TeamCount = teamCount;

            await _hunContext.Clients.All.SendAsync("Notify", $"Arkadaşlar takım {teamCount} kişilik olacaktır.");

            return Ok();
        }
    }
}
