# SimpleCyberTech Copilot Instructions

## Project Overview
SimpleCyberTech is an ASP.NET Core Razor Pages web application targeting .NET 10.0. It's a cybersecurity and IT support services website for small and medium-sized businesses in Southern California.

**Architecture**: Single ASP.NET Core Razor Pages application with client-side styling via Bootstrap and custom CSS.

## Key Technologies
- **.NET Framework**: .NET 10.0 (latest)
- **Web Framework**: ASP.NET Core Razor Pages
- **Nullable**: Enabled (`<Nullable>enable</Nullable>`)
- **Implicit Usings**: Enabled (`<ImplicitUsings>enable</ImplicitUsings>`)
- **Styling**: Bootstrap 5.x CDN, custom CSS with CSS variables (--sct-* brand colors), PostCSS/Autoprefixer, Tailwind CSS (devDependency)
- **CSS Variables**: Brand colors (--sct-charcoal, --sct-maroon, --sct-blue, --sct-silver, --sct-beige) + fonts (--font-header, --font-subheader, --font-regular) defined in site.css
- **Node Stack**: package.json with PostCSS, Autoprefixer, Tailwind (for dev tooling, not bundled into output)
- **Runtime**: Single executable in `bin/Debug/net10.0/SimpleCyberTech`

## Project Structure

```
SimpleCyberTech/
├── Pages/                 # Razor Pages (page + code-behind + CSS)
│   ├── Index.cshtml      # Home page with hero section and parallax effects
│   ├── About.cshtml      # About page
│   ├── Services.cshtml   # Services listing
│   ├── Contact.cshtml    # Contact form
│   ├── Privacy.cshtml    # Privacy policy
│   ├── Error.cshtml      # Error handling
│   ├── Shared/           # Layout and partials
│   │   ├── _Layout.cshtml         # Master layout
│   │   └── _ValidationScriptsPartial.cshtml
│   └── _ViewImports.cshtml, _ViewStart.cshtml
├── wwwroot/             # Static assets
│   ├── css/site.css     # Global styles
│   ├── js/site.js       # Global scripts
│   ├── img/             # Images (logos, backgrounds)
│   ├── video/           # MP4 videos (hero section)
│   └── lib/             # Bootstrap, jQuery, validation libs
├── Properties/
│   └── launchSettings.json  # Dev server config (ports 7000/7001)
├── appsettings.json     # Logging and host configuration
├── Program.cs           # Minimal hosting setup
└── SimpleCyberTech.csproj # Project configuration
```

## Page Component Conventions

Each page follows the **Razor Pages pattern** with three files per page:

1. **`.cshtml` file** - Markup using Razor syntax (@directives, @Model, @page)
2. **`.cshtml.cs` file** - Code-behind PageModel class (namespace: `SimpleCyberTech.Pages`)
3. **`.cshtml.css` file** - Component-scoped CSS (optional, auto-scoped by ASP.NET Core)

**Naming & Casing**: File names are lowercase (e.g., `index.cshtml`, `about.cshtml`), but class names are PascalCase (e.g., `IndexModel`, `AboutModel`). Note: There's an inconsistency where `Index.cshtml` exists alongside `index.cshtml.css` - treat both as referring to the same component.

**Example Pattern**:
- `index.cshtml` → `Index.cshtml.cs` (class `IndexModel : PageModel`)
- `Services.cshtml` → `Services.cshtml.cs` (class `ServicesModel : PageModel`)

**Minimal PageModel Pattern**: Most PageModels are currently minimal (only `OnGet()` with no logic):
```csharp
public class IndexModel : PageModel
{
    public void OnGet() { }
}
```

When adding logic:
- Use `OnGet()` method for GET requests
- Use `OnPost()` method for POST requests
- Set `ViewData["Title"]` for page titles (displayed in browser tab and meta tags)

## Key Files & Responsibilities

| File | Purpose |
|------|---------|
| [Program.cs](Program.cs) | Minimal ASP.NET Core setup: AddRazorPages(), middleware pipeline |
| [Pages/Shared/_Layout.cshtml](Pages/Shared/_Layout.cshtml) | Master layout with header nav, Bootstrap CDN, custom fonts |
| [Pages/Index.cshtml](Pages/Index.cshtml) | Hero section with video bg, parallax sections, Three Pillars content |
| [wwwroot/css/site.css](wwwroot/css/site.css) | Global typography, parallax, utility classes |
| [launchSettings.json](Properties/launchSettings.json) | Dev server: HTTP (7000), HTTPS (7001) |

## Build & Run Commands

```bash
# Development (auto-reload)
dotnet watch

# Build Release
dotnet build -c Release

# Run compiled binary
./SimpleCyberTech/bin/Debug/net10.0/SimpleCyberTech

# Publish
dotnet publish -c Release
```

**Dev URLs**: 
- HTTP: `http://localhost:7000`
- HTTPS: `https://localhost:7001`

## Styling Approach

- **Layout Framework**: Bootstrap 5 (via CDN in _Layout.cshtml)
- **Global Styles**: [wwwroot/css/site.css](wwwroot/css/site.css) with CSS variable system
- **CSS Variable System**: All brand colors and fonts defined as CSS custom properties at `:root` level:
  - Colors: `var(--sct-charcoal)`, `var(--sct-maroon)`, `var(--sct-blue)`, `var(--sct-silver)`, `var(--sct-beige)`, `var(--sct-roasted)`, `var(--sct-cocoa)`, `var(--sct-espresso)`
  - Fonts: `var(--font-header)` (Black Ops One), `var(--font-subheader)` (Oswald), `var(--font-regular)` (Raleway)
- **Utility Classes**: Pre-defined `.bg-sct-*` and `.text-sct-*` classes for quick styling
- **Scoped Styles**: Component `.cshtml.css` files auto-scoped by ASP.NET Core (About.cshtml.css, Services.cshtml.css, Index.cshtml.css)
- **Custom Features**: Parallax scrolling, hero video backgrounds, responsive navbar
- **Fonts**: Google Fonts (Raleway, Oswald, Black Ops One) preconnected in _Layout.cshtml for performance

### CSS Scoping Example
`About.cshtml.css` rules apply only to `About.cshtml` via generated scope attributes (`about-*-scope`).

### Adding Custom Colors
1. Add CSS variable to `:root` in [wwwroot/css/site.css](wwwroot/css/site.css)
2. Create utility class pair (`.bg-sct-*` and `.text-sct-*`)
3. Reference in markup using `var(--sct-colorname)` or utility class

## Naming Conventions

- **Classes**: PascalCase (`IndexModel`, `PageModel`)
- **Properties/Fields**: PascalCase
- **Variables**: camelCase
- **Files**: PascalCase for code-behind (e.g., `Index.cshtml.cs`), lowercase for .cshtml
- **Namespaces**: `SimpleCyberTech.Pages`
- **HTML IDs/Sections**: PascalCase (e.g., `id="HeroSection"`, `id="ProtectYourBusiness"`)

## Content Structure

Pages typically contain:
- **Hero/Header Section**: Eye-catching intro with visuals
- **Content Sections**: Organized by semantic `<section>` elements
- **Cards/Grids**: Bootstrap grid system (`.row`, `.col-*`)
- **Responsive Design**: Mobile-first with breakpoints (sm, md, lg, xl)

## Common Patterns

### Adding a New Page
1. Create `Pages/NewPage.cshtml` with `@page` and `@model`
2. Create `Pages/NewPage.cshtml.cs` with `public class NewPageModel : PageModel`
3. Add navigation link in [_Layout.cshtml](Pages/Shared/_Layout.cshtml) navbar
4. Use Bootstrap classes for responsive layout

### Form Handling
- Use `OnPost()` in code-behind
- Include `[ValidateAntiForgeryToken]` for security
- Include `_ValidationScriptsPartial.cshtml` in page
- Use `asp-` tag helpers for form elements

### Static Assets
Place in `wwwroot/` subdirectories and reference with `~/` path prefix in HTML/CSS.

## Environment Configuration

- **Development**: `ASPNETCORE_ENVIRONMENT=Development` (launchSettings.json)
- **Production**: HSTS enabled, exception handler at `/Error`
- **Logging**: Default="Information", Microsoft.AspNetCore="Warning"

## ASP.NET Core Integration Features

- **MapStaticAssets()**: Auto-caches versioned static files and generates etags (see Program.cs)
- **Scoped CSS**: ASP.NET Core automatically bundles `.cshtml.css` files into `SimpleCyberTech.styles.css` and applies scope attributes (visible in obj/Debug/net10.0/scopedcss/)
- **Tag Helpers**: Use `asp-` tag helpers for routing (`asp-page`, `asp-area`) and versioning (`asp-append-version="true"`)

## Static Assets Handling

- Place assets in `wwwroot/` subdirectories (css, js, img, video, lib)
- Reference with `~/` path prefix in HTML/CSS
- Large MP4 videos in `wwwroot/video/` are streamed (no bundling)
- Bootstrap & jQuery libraries loaded from `wwwroot/lib/` (CDN fallback available)

## Important Notes

- **Nullable Reference Types**: Enabled project-wide; use `#nullable disable` cautiously
- **Target Framework**: .NET 10.0 - use modern C# features (records, nullable types, etc.)
- **Static Assets Optimization**: Configure via [SimpleCyberTech.csproj](SimpleCyberTech.csproj) if needed
- **Video Assets**: Large MP4 files in `wwwroot/video/` - optimize for web delivery

## When Adding Features

Ask yourself:
1. Is this a new page? → Follow Razor Pages pattern (3 files per page)
2. Is this styling? → Use [wwwroot/css/site.css](wwwroot/css/site.css) or component `.cshtml.css`
3. Is this client-side logic? → Add to [wwwroot/js/site.js](wwwroot/js/site.js) or inline in `.cshtml`
4. Is this a data service? → Create new namespace/folder (current project doesn't have services yet)
