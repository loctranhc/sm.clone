using System.ComponentModel.DataAnnotations;

namespace Domains.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid Code { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(25)]
        public string AccountName { get; set; } = string.Empty;
        public virtual PersonalInformation PersonalInformation { get; set; } = new PersonalInformation();
        public virtual ICollection<Address> Addresses {get; set;} = Array.Empty<Address>();
    }
}