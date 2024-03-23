using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domains.Entities
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; } = string.Empty;
        [Required]
        public int PhoneCountryCode { get; set; }
        [Required]
        public bool IsPhoneValidation { get; set; } = false;
        [ForeignKey("PhoneType")]
        public int PhoneTypeId { get; set; }
        public virtual PhoneType PhoneType { get; set; } = new PhoneType();
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationId { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; } = new PersonalInformation();
    }
}