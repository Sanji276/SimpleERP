using SimpleERP.Models.Account;
using SimpleERP.Models.Error;
using SimpleERP.Repository.Generic;

namespace SimpleERP.Repository.Account
{
	public interface IAccountRepository: IGenericRepository<UserRegisterModel, ErrorHandlingModel>
	{

	}
}
