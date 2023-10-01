using System.ComponentModel.DataAnnotations;

namespace Crito.Models
{
    public class SubscribeForm
    {
        [Key]
        [EmailAddress]

        public string Email { get; set; } = null!;
    }
}
