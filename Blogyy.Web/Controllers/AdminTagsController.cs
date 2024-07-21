using Blogyy.Web.Data;
using Blogyy.Web.Models.Domain;
using Blogyy.Web.Models.ViewModdels;
using Microsoft.AspNetCore.Mvc;

namespace Blogyy.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogyyDbContext blogyyDbContext;

        public AdminTagsController(BlogyyDbContext blogyyDbContext)
        {
            this.blogyyDbContext = blogyyDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName ("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping the AddTagRequest to tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            blogyyDbContext.Tags.Add(tag);
            blogyyDbContext.SaveChanges();
            
            return View("Add");
        }
    }
}
