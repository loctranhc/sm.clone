using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domains.Entities
{
    public class PersonalInformation
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string MiddleName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string NickName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        [Required]
        public bool IsEmailValidation { get; set; } = false;
        [MaxLength(25)]
        public string PassportNumber { get; set; } = string.Empty;
        [MaxLength(25)]
        public string IdentificationCardNumber { get; set; } = string.Empty;
        public virtual User User { get; set; } = new User();
    }
}