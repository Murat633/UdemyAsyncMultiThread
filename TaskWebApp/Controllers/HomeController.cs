using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> getString(CancellationToken token)
        {
           try
            {
                _logger.LogInformation("İŞLEM BAŞLATILDI");
                await  Task.Delay(3000, token);
                var result = new HttpClient().GetStringAsync("https://google.com");


                var data = await result;

                _logger.LogInformation("İŞLEM BİTTİ");
                return Ok(data);
            }
            catch (TaskCanceledException)
            {
                _logger.LogInformation("işlem iptal edildi");
                return BadRequest();
            }
        }
    }
}
