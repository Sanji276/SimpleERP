using Microsoft.AspNetCore.Identity;
using SimpleERP.Database;
using SimpleERP.Models.Account;
using SimpleERP.Models.Error;
using SimpleERP.Repository.Generic;

namespace SimpleERP.Repository.Account
{
	public class AccountRepository : IAccountRepository, IGenericRepository<UserRegisterModel, ErrorHandlingModel>
	{
		private readonly SimpleERPDbContext _dbContext;
		private readonly UserManager<ApplicationUser> _userManager;

		async Task<(UserRegisterModel Entity1, ErrorHandlingModel Entity2)> IGenericRepository<UserRegisterModel, ErrorHandlingModel>.Add(UserRegisterModel entity)
		{
			try
			{
				var user = new ApplicationUser
				{
					FirstName = entity.FirstName,
					LastName = entity.LastName,
					Email = entity.Email,
					UserName = entity.Email
				};
				var result = await _userManager.CreateAsync(user, entity.Password);

				var userEntity = new UserRegisterModel
				{
					identityResult = result
				};
				var errorEntity = new ErrorHandlingModel();
				errorEntity.ErrorMessageList = new List<string>();
				if (result.Succeeded)
				{
					errorEntity.ErrorCode = 000;
					errorEntity.ErrorMessage = "Success";
					errorEntity.IsSuccess = true;
				}
				else
				{
					errorEntity.ErrorCode = 111;
					errorEntity.ErrorMessage = "Failed";
					foreach (var item in result.Errors)
					{
						errorEntity.ErrorMessageList.Add(item.Description);
					}
					errorEntity.IsSuccess = false;
				}
				return (userEntity, errorEntity);
			}
			catch (Exception)
			{
				throw;
			}
		}
		public AccountRepository(SimpleERPDbContext dbContext, UserManager<ApplicationUser> userManager)
		{
			_dbContext = dbContext;
			_userManager = userManager;
		}

		public Task Delete(UserRegisterModel entity)
		{
			throw new NotImplementedException();
		}

		public Task<UserRegisterModel> Update(UserRegisterModel entity)
		{
			throw new NotImplementedException();
		}

		
	}
}
