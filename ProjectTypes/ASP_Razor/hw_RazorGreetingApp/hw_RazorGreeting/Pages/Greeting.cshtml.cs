using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw_RazorGreeting.Pages
{
    public class GreetingPageModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        
        [BindProperty]
        public string LastName { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string greeting = $"Hello sweet {FirstName} {LastName}, Welcome To Bub Land!!!\nHMMMM!!!!!!!!!!!!!!";

            ViewData["Greeting"] = greeting;

            return Page();

            //if (ModelState.IsValid)
            //{
            //    string greeting = $"Hello sweet {FirstName} {LastName}, Welcome To Bub Land!!!";

            //    ViewData["Greeting"] = greeting;

            //    return Page();
            //}
            //else
            //{
            //    return Page();
            //}
        }
    }
}
