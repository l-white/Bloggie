using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloggie.Models.ViewModels;
using Bloggie.Data;
using Bloggie.Models.Domain;

namespace Bloggie.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {

        private readonly BloggieDbContext bloggieDbContext;

        [BindProperty]
        public AddBlogPost AddBlogPostRequest { get; set; }

        public AddModel(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;   
        }

        public void OnGet()
        {
        }
        // read values from form
        public IActionResult OnPost()
        {
            // have to talk to the table to add a new blog post
            // EF Core gives us the Add method
            var blogPost = new BlogPost()
            {
                Heading = AddBlogPostRequest.Heading,
                PageTitle = AddBlogPostRequest.PageTitle,
                Content = AddBlogPostRequest.Content,
                ShortDescription = AddBlogPostRequest.ShortDescription,
                FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
                UrlHandle = AddBlogPostRequest.UrlHandle,
                PublishedDate = AddBlogPostRequest.PublishedDate,
                Author = AddBlogPostRequest.Author,
                Visible = AddBlogPostRequest.Visible

            };

            bloggieDbContext.BlogPosts.Add(blogPost);
            // call context again to save the changes to the database
            bloggieDbContext.SaveChanges();

            return RedirectToPage("/Admin/Blogs/List");
        }
    }
}