using System.ComponentModel.DataAnnotations;

namespace Domains.Entities
{
    public class PhoneType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}