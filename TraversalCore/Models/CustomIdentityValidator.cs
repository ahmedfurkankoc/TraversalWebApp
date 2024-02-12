using Microsoft.AspNetCore.Identity;

namespace TraversalCore.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Code = "PasswordTooShort",
				Description = $"Şifre minimum {length} karakter olmalıdır."
			};
		}
	}
}
