using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StefaniniCore.UI.Controllers
{
    public class UserSystemsController : MainController
    {
        private readonly ILogger<UserSystemsController> _logger;

        public UserSystemsController(ILogger<UserSystemsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Detail with the fields of UserSystem.
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
            return View();
        }

        /// <summary>
        /// SingIn/Login on application.
        /// </summary>
        /// <returns></returns>
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
