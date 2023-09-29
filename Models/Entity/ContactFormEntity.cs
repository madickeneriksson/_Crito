using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class ContactFormEntity
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Key]
        public string Email { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
