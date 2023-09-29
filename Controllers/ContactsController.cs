using Crito.Models;
using Crito.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
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

        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {
            if (!ModelState.IsValid)
            
                return CurrentUmbracoPage();
            
               



            using var mail = new MailService("no-reaoly@crito.com", "smtp.crito.com", 465, "support@crito.com", "Bytmig123!");
            //to sender
             mail.SendAsync(contactForm.Email, "Our request was received", "Hi your request was received, we will contact you").ConfigureAwait(false);
            // to us
             mail.SendAsync("support@crito.com", $"{contactForm.Name} sent a contact request", contactForm.Message).ConfigureAwait(false);

                return LocalRedirect(contactForm.ReadirectUrl ?? "/");
           
           
        }
        
    }
}
