using Microsoft.AspNetCore.Mvc;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get() => "This api is working, and so ... \"Hello World!\" ... may be ...";
    }
}