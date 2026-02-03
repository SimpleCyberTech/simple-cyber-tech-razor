using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using simplecybertech.Models;

namespace simplecybertech.Pages;

public class SitemapModel : PageModel
{
    private readonly IOptions<BusinessInfo> _businessInfo;

    public List<(string Slug, string Name)> Cities { get; set; } = new();

    public SitemapModel(IOptions<BusinessInfo> businessInfo)
    {
        _businessInfo = businessInfo;
    }

    public IActionResult OnGet()
    {
        var info = _businessInfo.Value;
        
        // Get all cities from configuration and convert to slugs
        Cities = info?.AreasServed?
            .Where(a => a.Type == "City" && !string.IsNullOrEmpty(a.Name))
            .Select(a => (
                Slug: a.Name.ToLower().Replace(" ", "-"),
                Name: a.Name
            ))
            .OrderBy(c => c.Name)
            .ToList() ?? new();

        // Set content type for XML
        Response.ContentType = "application/xml";
        
        return Page();
    }
}
