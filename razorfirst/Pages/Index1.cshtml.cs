using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorfirst.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            Name = "This is the " + Request.Form["name"];
            Email = "This is the " + Request.Form["email"];

            Description = Name + " " + Email;

            Name = "";
            Email = "";

            ModelState.Remove("Name");
            ModelState.Remove("Email");

        }
    }
}
