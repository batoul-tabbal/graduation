using grade.LogIn;
using grade.Services;
using Microsoft.AspNetCore.Mvc;

namespace grade.Controllers
{
    public class UserController : Controller
    {
        private readonly UserServices _userService;

        public UserController(UserServices userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUser(string username)
        {
            _userService.DeleteUser(username);
            return Ok();
        }

        [HttpPost]
        public IActionResult ResetPassword(string username, string newPassword)
        {
            _userService.ResetPassword(username, newPassword);
            return Ok();
        }
    }

}
