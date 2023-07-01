using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw_RazorPagesMiniProject.Pages;

[BindProperties]
public class PersonModel : PageModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Age { get; set; }
    public void OnGet()
    {
    }
}
