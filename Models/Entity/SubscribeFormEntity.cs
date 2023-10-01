using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class SubscribeFormEntity
    {
        [Key]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
