
using Crito.Context;
using Crito.Models;
using Crito.Models.Entity;

namespace Crito.Services
{
    public class ContactFormService
    {
        private readonly DataContext _context;

        public ContactFormService(DataContext context)
        {
            _context = context;
        }

        public async Task SaveAsync(ContactForm form)
        {
            _context.ContactForms.Add(new ContactFormEntity
            {
                Email = form.Email,
                Name = form.Name,
                Message = form.Message,
            });
            await _context.SaveChangesAsync();
        }
    }
}
