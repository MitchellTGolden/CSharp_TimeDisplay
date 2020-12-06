using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View();
        }
        
    }
}