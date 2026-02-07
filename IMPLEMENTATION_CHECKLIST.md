# SEO & Performance Implementation Checklist

Track your progress implementing the audit recommendations.

---

## 🔥 CRITICAL FIXES (Do First)

- [ ] **Fix Google Tag Manager render blocking**
  - [X] Remove GTM script from `<head>` in `_Layout.cshtml`
  - [X] Add GTM script before `</body>`
  - [ ] Test with Lighthouse
  - [ ] Verify GTM still fires correctly

- [ ] **Add response compression**
  - [ ] Add compression services to `Program.cs`
  - [ ] Add `UseResponseCompression()` middleware
  - [ ] Add required using statements
  - [ ] Test with DevTools Network tab
  - [ ] Verify `content-encoding` header present

- [ ] **Optimize video files**
  - [ ] Compress `homepage-hero-section.mp4` (target: <3MB)
  - [ ] Compress `about-us-hero-section.mp4` (target: <3MB)
  - [ ] Compress `contact-us-hero-section.mp4` (target: <3MB)
  - [ ] Compress `services-hero-section.mp4` (target: <3MB)
  - [ ] Create poster images for all videos
  - [ ] Update all video tags with `preload="metadata"` and `poster`
  - [ ] Test video playback on desktop
  - [ ] Test video playback on mobile

- [X] **Fix canonical URL consistency**
  - [X] Choose www vs non-www format
  - [X] Update `appsettings.json` BaseUrl
  - [X] Verify canonical tags in `_Layout.cshtml`
  - [X] Set up 301 redirect in hosting config

- [ ] **Implement FAQ schema**
  - [X] Update FAQ.cshtml PageSchema section
  - [X] Add all 13 FAQ questions and answers
  - [ ] Test with Google Rich Results Test
  - [ ] Verify FAQ rich results appear

**Target Completion: This Week**

---

## 🟡 HIGH PRIORITY (This Week/Month)

### Performance

- [ ] **Convert images to WebP**
  - [ ] Audit all JPG/PNG images in `/wwwroot/img/`
  - [ ] Convert to WebP (use online tools or `cwebp`)
  - [ ] Update image references in Razor pages
  - [ ] Test with picture element for fallback support
  - [ ] Measure page size reduction

- [ ] **Implement output caching**
  - [ ] Add `AddOutputCache()` to services
  - [ ] Add `UseOutputCache()` middleware
  - [ ] Configure cache policies for different page types
  - [ ] Test cache headers
  - [ ] Monitor performance improvement

- [ ] **Optimize font loading**
  - [ ] Add `font-display: swap` to Google Fonts link
  - [ ] Consider reducing from 3 to 2 font families
  - [ ] Preload critical font files
  - [ ] Test font loading performance

### SEO Enhancement

- [ ] **Add HowTo schema**
  - [ ] Update SchemaService with HowTo method
  - [ ] Add HowTo schema to "How We Work" section (About Us)
  - [ ] Test with Google Rich Results Test

- [ ] **Add video schema**
  - [ ] Update SchemaService with VideoObject method
  - [ ] Add VideoObject schema to all hero videos
  - [ ] Include thumbnail, duration, description

- [ ] **Add Google Maps embed**
  - [ ] Embed Google Map on Contact Us page
  - [ ] Add schema for GeoCoordinates
  - [ ] Test map responsiveness

**Target Completion: End of Month**

---

## 🟢 MEDIUM PRIORITY (This Month/Quarter)

### Content Enhancement

- [ ] **Enhance location pages with unique content**
  - [ ] Create unique content template (3-4 paragraphs per city)
  - [ ] Research local business ecosystems for top 10 cities
  - [ ] Add unique content to Irvine page
  - [ ] Add unique content to Newport Beach page
  - [ ] Add unique content to Costa Mesa page
  - [ ] Add unique content to Anaheim page
  - [ ] Add unique content to Huntington Beach page
  - [ ] Add unique content to remaining cities (29 more)

- [ ] **Create blog/knowledge base**
  - [ ] Set up blog page structure
  - [ ] Create 5 pillar articles:
    - [ ] "Complete Guide to Cybersecurity for Small Businesses"
    - [ ] "Understanding Penetration Testing: A Beginner's Guide"
    - [ ] "Top 10 Cybersecurity Threats in 2026"
    - [ ] "How to Choose a Cybersecurity Provider"
    - [ ] "Cybersecurity Compliance: HIPAA, PCI-DSS, SOC 2"
  - [ ] Add Article schema to blog posts
  - [ ] Implement RSS feed

- [ ] **Add review schema**
  - [ ] Collect client testimonials
  - [ ] Implement Review schema in SchemaService
  - [ ] Add reviews to Home page
  - [ ] Add AggregateRating to Organization schema

- [ ] **Create downloadable resources**
  - [ ] Create "Cybersecurity Checklist for Small Businesses" PDF
  - [ ] Create "2026 Threat Landscape Report" whitepaper
  - [ ] Create "Cost of a Data Breach" infographic
  - [ ] Add gated content forms (lead generation)

### Technical Improvements

- [ ] **Optimize Bootstrap bundle**
  - [ ] Audit which Bootstrap components are used
  - [ ] Create custom Bootstrap build with only needed components
  - [ ] OR switch to Bootstrap CDN with subresource integrity

- [ ] **Optimize FontAwesome**
  - [ ] Identify which icons are actually used
  - [ ] Create custom FontAwesome subset
  - [ ] OR switch to inline SVG icons

- [ ] **Add security headers**
  - [ ] Add Content-Security-Policy header
  - [ ] Add HSTS header
  - [ ] Add X-Content-Type-Options header
  - [ ] Add X-Frame-Options header
  - [ ] Add Referrer-Policy header
  - [ ] Test with Security Headers scanner

**Target Completion: End of Quarter**

---

## 🔵 LOW PRIORITY (Long-term)

### Progressive Enhancement

- [ ] **Implement PWA capabilities**
  - [ ] Create `manifest.json`
  - [ ] Add service worker for offline support
  - [ ] Add app icons (multiple sizes)
  - [ ] Test installation on mobile

- [ ] **Add CDN for static assets**
  - [ ] Set up CDN (Cloudflare, Azure CDN, etc.)
  - [ ] Configure CDN for `/wwwroot/` assets
  - [ ] Update asset references
  - [ ] Test CDN performance
  - [ ] Monitor CDN costs

- [ ] **Create comparison pages**
  - [ ] "Managed Security vs In-House IT"
  - [ ] "Antivirus vs EDR vs XDR"
  - [ ] "VPN vs Zero Trust"
  - [ ] Add comparison schema when available

- [ ] **Add case studies**
  - [ ] Create 3 anonymized case studies
  - [ ] Add CaseStudy schema (if available) or Article schema
  - [ ] Include problem/solution/results format

- [ ] **Enhance glossary**
  - [ ] Add DefinedTerm schema for each term
  - [ ] Add 50+ cybersecurity terms
  - [ ] Cross-link terms to service pages
  - [ ] Add search functionality

**Target Completion: Next 6 Months**

---

## 📊 Ongoing Monitoring

### Weekly

- [ ] Check Google Search Console for:
  - [ ] Crawl errors
  - [ ] Coverage issues
  - [ ] Mobile usability issues
  - [ ] Core Web Vitals
  - [ ] Search performance trends

### Monthly

- [ ] Run Lighthouse audit on:
  - [ ] Home page
  - [ ] Services page
  - [ ] About page
  - [ ] Sample location page
  - [ ] FAQ page

- [ ] Validate structured data:
  - [ ] Google Rich Results Test
  - [ ] Schema.org validator
  - [ ] Check for any warnings/errors

- [ ] Performance check:
  - [ ] PageSpeed Insights (mobile & desktop)
  - [ ] GTmetrix
  - [ ] WebPageTest (optional)

### Quarterly

- [ ] Full SEO audit
- [ ] Competitor analysis
- [ ] Content refresh (update dates, stats)
- [ ] Review and update schema markup
- [ ] Check for broken links
- [ ] Update sitemap.xml with new pages

---

## 🎯 Success Metrics

### Performance Targets

| Metric | Current | Target | Status |
|--------|---------|--------|--------|
| Lighthouse Performance | TBD | >90 | ⏳ |
| First Contentful Paint | TBD | <1.5s | ⏳ |
| Largest Contentful Paint | TBD | <2.5s | ⏳ |
| Cumulative Layout Shift | TBD | <0.1 | ⏳ |
| Total Blocking Time | TBD | <200ms | ⏳ |

### SEO Targets

| Metric | Current | Target | Status |
|--------|---------|--------|--------|
| Organic Traffic | Baseline | +50% in 6mo | ⏳ |
| Local Pack Appearances | TBD | Top 3 for key terms | ⏳ |
| Featured Snippets | 0 | 5+ | ⏳ |
| Schema Validation | TBD | 100% pass | ⏳ |
| Mobile Usability | TBD | 0 errors | ⏳ |

---

## 📝 Notes

Use this section to track implementation details, issues encountered, and solutions:

```
Date: ___________
Fix Implemented: ___________
Issues Encountered: ___________
Resolution: ___________
Time Taken: ___________
Result: ___________

---

Date: ___________
Fix Implemented: ___________
Issues Encountered: ___________
Resolution: ___________
Time Taken: ___________
Result: ___________
```

---

## 🎓 Resources

### Testing Tools
- [Google PageSpeed Insights](https://pagespeed.web.dev/)
- [Google Rich Results Test](https://search.google.com/test/rich-results)
- [Google Search Console](https://search.google.com/search-console)
- [Schema.org Validator](https://validator.schema.org/)
- [GTmetrix](https://gtmetrix.com/)
- [WebPageTest](https://www.webpagetest.org/)
- [Lighthouse CI](https://github.com/GoogleChrome/lighthouse-ci)

### Video Compression
- [HandBrake](https://handbrake.fr/) (GUI)
- [FFmpeg](https://ffmpeg.org/) (Command line)
- [CloudConvert](https://cloudconvert.com/) (Online)

### Image Optimization
- [Squoosh](https://squoosh.app/) (Google's image compressor)
- [cwebp](https://developers.google.com/speed/webp/docs/cwebp) (WebP converter)
- [TinyPNG](https://tinypng.com/) (Online compression)

### Documentation
- [ASP.NET Core Performance Best Practices](https://learn.microsoft.com/en-us/aspnet/core/performance/performance-best-practices)
- [Schema.org Documentation](https://schema.org/)
- [Google Search Central](https://developers.google.com/search)
- [Web.dev](https://web.dev/) (Performance guides)

---

**Last Updated:** ___________  
**Next Review Date:** ___________
