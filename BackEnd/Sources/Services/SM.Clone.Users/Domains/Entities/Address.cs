using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domains.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string StateOrProvince { get; set; } = string.Empty;
        [Required]
        public string ZipOrPostalCode { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
        [ForeignKey("AddressType")]
        public int AddressTypeId { get; set; }
        public virtual AddressType AddressType { get; set; } = new AddressType();
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationId { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; } = new PersonalInformation();
    }
}