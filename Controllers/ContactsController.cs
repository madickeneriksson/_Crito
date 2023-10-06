using Crito.Context; // Importera denna
using Crito.Models.Entity;
using Crito.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;


namespace Crito.Controllers
{
    public class ContactsController : SurfaceController
    {
        private readonly DataContext _context; 

        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, DataContext context) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _context = context; 
        }

        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            // save contact form to database
            var contactEntity = new ContactFormEntity
            {
                Name = contactForm.Name,
                Email = contactForm.Email,
                Message = contactForm.Message
            };

            _context.ContactForms.Add(contactEntity);
            _context.SaveChanges();

            return LocalRedirect(contactForm.ReadirectUrl ?? "/");
        }
    }
}
