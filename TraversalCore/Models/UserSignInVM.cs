using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
    public class UserSignInVM
    {

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; } = null!;
    }
}
