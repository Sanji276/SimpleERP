using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SimpleERP.Models.Account
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
    }

    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
		public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }

	public class UserRegisterModel
	{
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
		[EmailAddress]
		public string? Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password Didn't Match.")]
        public string? ConfirmPassword { get; set; }
        public IdentityResult? identityResult { get; set; }
    }
}
