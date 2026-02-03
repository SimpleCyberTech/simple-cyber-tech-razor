using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using simplecybertech.Models;

namespace simplecybertech.Pages;

public class ServicesAreaModel : PageModel
{
    private readonly IOptions<BusinessInfo> _businessInfo;

    public string CityName { get; set; } = "";
    public string CitySlug { get; set; } = "";
    public Dictionary<string, string> NearbyServices { get; set; } = new();

    public ServicesAreaModel(IOptions<BusinessInfo> businessInfo)
    {
        _businessInfo = businessInfo;
    }

    public IActionResult OnGet(string? city)
    {
        // Return 404 if city parameter is missing
        if (string.IsNullOrWhiteSpace(city))
        {
            return NotFound();
        }

        // Validate and get city from configuration
        var info = _businessInfo.Value;
        
        // Normalize the city parameter (URL slug to proper city name)
        var normalizedCity = city.Replace("-", " ");
        
        // Find the city in AreasServed
        var foundCity = info?.AreasServed?
            .FirstOrDefault(a => a.Type == "City" && 
                                 a.Name?.Equals(normalizedCity, StringComparison.OrdinalIgnoreCase) == true);

        // If city not found, return 404
        if (foundCity == null)
        {
            return NotFound();
        }

        CityName = foundCity.Name ?? "";
        CitySlug = city;

        // Build nearby services list (all cities except current one, plus regions)
        NearbyServices = new Dictionary<string, string>();
        
        // Add all cities except the current one
        var citiesInConfig = info?.AreasServed?
            .Where(a => a.Type == "City" && a.Name != CityName)
            .OrderBy(a => a.Name);

        if (citiesInConfig != null)
        {
            foreach (var c in citiesInConfig.Take(12)) // Limit to 12 nearby cities
            {
                var slug = c.Name?.ToLower().Replace(" ", "-") ?? "";
                NearbyServices[slug] = c.Name ?? "";
            }
        }

        return Page();
    }
}

