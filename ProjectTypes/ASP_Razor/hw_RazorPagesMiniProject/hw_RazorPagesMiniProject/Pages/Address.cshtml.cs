using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw_RazorPagesMiniProject.Pages;

[BindProperties]
public class AddressModel : PageModel
{
    public string StreetAddress { get; set; } 
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public void OnGet()
    {
    }
}
