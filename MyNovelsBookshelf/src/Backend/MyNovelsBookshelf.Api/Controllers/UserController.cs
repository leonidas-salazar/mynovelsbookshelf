using Microsoft.AspNetCore.Mvc;
using MyNovelsBookshelf.Application.UserCases.Users.Register;
using MyNovelsBookshelf.Communication.Requests.Users;
using MyNovelsBookshelf.Communication.Responses.Users;

namespace MyNovelsBookshelf.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult RegisterUser(RequestRegisterUserJson request)
        {
            var register = new RegisterUserUseCase();

            var response = register.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
