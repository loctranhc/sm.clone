using Microsoft.AspNetCore.Identity;

namespace Domains.Entities
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime CreatedDate {get; set;} = DateTime.UtcNow;
    }
}