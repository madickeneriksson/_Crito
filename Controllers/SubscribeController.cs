using Crito.Context;
using Crito.Models;
using Crito.Models.Entity;
using Crito.Services;
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
    public class SubscribeController : SurfaceController
    {
        private readonly DataContext _context; 

        public SubscribeController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, DataContext context) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _context = context; 
        }

        [HttpPost]
        public IActionResult Index(SubscribeForm subscribeForm)
        {
            if (!ModelState.IsValid)
                ModelState.Clear();
            return CurrentUmbracoPage();

            // Sparar SubscribeFormEntity i databasen
            var subscribeEntity = new SubscribeFormEntity
            {
                Email = subscribeForm.Email
            };

            _context.SubscribeForms.Add(subscribeEntity);
            _context.SaveChanges();

            return CurrentUmbracoPage();
        }

    }

    }
