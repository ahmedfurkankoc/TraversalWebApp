using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
	public class UserRegisterVM
	{
		[Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; } = null!;

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
		public string Surname { get; set; } = null!;

		[Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
		public string Username { get; set; } = null!;

		[Required(ErrorMessage = "Lütfen email adresini giriniz")]
		public string Email { get; set; } = null!;

		[Required(ErrorMessage = "Lütfen şifreyi giriniz")]
		public string Password { get; set; } = null!;

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; } = null!;
	}
}
