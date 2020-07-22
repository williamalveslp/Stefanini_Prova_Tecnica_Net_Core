using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.UserSystemInputModel;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Infra.CrossCutting.Constants;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace StefaniniCore.UI.Controllers
{
    public class UserSystemsController : MainController
    {
        private readonly IUserSystemAppService _appService;
        private readonly ILogger<UserSystemsController> _logger;

        public UserSystemsController(IUserSystemAppService appService, ILogger<UserSystemsController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        public IActionResult Detail(int? userSystemId)
        {
            try
            {
                if ((userSystemId != null) && (userSystemId > 0))
                    return View(_appService.GetById((int)userSystemId));
                else
                    return View(_appService.GetListsPopulated());
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }

        public IActionResult SignIn()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ConstAuthentication.CookieName)
                    return RedirectToAction("List", "Tasks");
            }

            return View(new UserSystemSignInViewModel());
        }

        public IActionResult SignOut()
        {
            RemoveAuthentication();
            return RedirectToAction("SignIn", "UserSystems");
        }

        [HttpPost]
        public IActionResult Save(UserSystemInputModel inputModel)
        {
            try
            {
                var userSystem = _appService.Save(inputModel);

                if (IsAlreadyAuthenticated())
                    return SuccessMessage("Salvo com sucesso!", userSystem.Id, false);

                AddAuthentication(userSystem);

                return SuccessMessage("Salvo com sucesso!", userSystem.Id, false, "/Tasks/List");
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }

        [HttpPost]
        public IActionResult RegisterSignIn(UserSystemSignInInputModel inputModel)
        {
            try
            {
                var userSystem = _appService.GetSignIn(inputModel);
                
                AddAuthentication(userSystem);
                return SuccessMessage("Salvo com sucesso!", userSystem.Id, false, "/Tasks/List");
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }

        #region .: PRIVATE METHODS :.
        private void AddAuthentication(UserSystem userSystem)
        {
            RemoveAuthentication();

            var grandmClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userSystem.UserName),
                // others claims
            };

            var grandmaIdentity = new ClaimsIdentity(grandmClaims, "User Identity");

            var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });

            HttpContext.SignInAsync(userPrincipal);
        }

        private void RemoveAuthentication()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ConstAuthentication.CookieName)
                {
                    Response.Cookies.Delete(cookie);
                }
            }

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private bool IsAlreadyAuthenticated()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ConstAuthentication.CookieName)                
                    return true;                
            }
            return false;
        }
        #endregion
    }
}
