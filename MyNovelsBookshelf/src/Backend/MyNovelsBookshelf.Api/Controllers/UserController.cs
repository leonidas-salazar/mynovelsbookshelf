using Microsoft.AspNetCore.Mvc;

namespace MyNovelsBookshelf.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}
