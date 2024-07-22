using Microsoft.AspNetCore.Mvc;
using SimpleERP.Models.Account;
using SimpleERP.Repository.Account;

namespace SimpleERP.Controllers
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
					var (response1, response2) =  await this.accountRepository.Add(user);
					if(response2.IsSuccess)
					{
						return RedirectToAction("Login","Account");
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

