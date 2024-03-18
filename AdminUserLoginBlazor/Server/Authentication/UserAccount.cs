using System.ComponentModel.DataAnnotations;

namespace AdminUserLoginBlazor.Server.Authentication
{
    public class UserAccount
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
