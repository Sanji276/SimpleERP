﻿using Microsoft.AspNetCore.Mvc;
using SimpleERP.Models.Account;
using SimpleERP.Repository.Account;

namespace SimpleERP.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginModel userDetails)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var (userRegisterResponse, ErrorHandlingResponse) = await accountRepository.Add(user);
                    if (ErrorHandlingResponse.IsSuccess)
                    {
                        return RedirectToAction("Login", "Account");
                    }
                }
                return View(user);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

