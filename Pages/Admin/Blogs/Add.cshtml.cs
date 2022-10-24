using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloggie.Models.ViewModels;

namespace Bloggie.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        public AddBlogPost AddBlogPostRequest { get; set; }

        public void OnGet()
        {
        }
        // read values from form
        public void OnPost()
        {
        }
    }
}