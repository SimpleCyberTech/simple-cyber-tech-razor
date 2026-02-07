using Microsoft.Extensions.Options;
using System.Text.Json;
using simplecybertech.Models;

namespace simplecybertech.Services
{
    public interface ISchemaService
    {
        string GetGlobalSchema();
        string GetBreadcrumbSchema(string pageName, string pagePath);
        string GetOrganizationSchema();
        string GetServiceSchema(ServiceInfo service);
        string GetContactPageSchema();
        string GetFAQSchema(string question, string answer);
        string GetFAQPageSchema(List<(string question, string answer)> faqs);
        string GetWebPageSchema(string pageName, string description);
        string GetAboutPageSchema();
        string GetServicesCollectionSchema();
        string GetLocalBusinessSchema();
        string GetLocationSpecificSchema(string cityName, string citySlug);
        string GetGlossarySchema(List<GlossaryTerm> terms);
    }

    public class SchemaService : ISchemaService
    {
        private readonly SiteSettings _site;
        private readonly BusinessInfo _business;
        private readonly NavigationSettings _nav;
        private readonly IOptions<List<ServiceInfo>> _services;

        public SchemaService(
            IOptions<SiteSettings> site, 
            IOptions<BusinessInfo> business,
            IOptions<NavigationSettings> nav,
            IOptions<List<ServiceInfo>> services)
        {
            _site = site.Value;
            _business = business.Value;
            _nav = nav.Value;
            _services = services;
        }

        public string GetGlobalSchema()
        {
            var schema = new
            {
                @context = "https://schema.org",
                @graph = new object[]
                {
                    new {
                        @type = _business.BusinessTypes,
                        @id = $"{_site.BaseUrl}/#organization",
                        name = _business.LegalName,
                        url = _site.BaseUrl,
                        telephone = _business.Telephone,
                        email = _business.Email,
                        address = new {
                            @type = "PostalAddress",
                            streetAddress = _business.Address.StreetAddress,
                            addressLocality = _business.Address.AddressLocality,
                            addressRegion = _business.Address.AddressRegion,
                            postalCode = _business.Address.PostalCode,
                            addressCountry = _business.Address.AddressCountry
                        },
                        openingHoursSpecification = _business.OpeningHours.Select(h => new {
                            @type = "OpeningHoursSpecification",
                            dayOfWeek = h.DaysOfWeek,
                            opens = h.Opens,
                            closes = h.Closes
                        }),
                        knowsAbout = _business.KnowsAbout,
                        areaServed = _business.AreasServed.Select(a => new { @type = a.Type, name = a.Name })
                    },
                    new {
                        @type = "WebSite",
                        @id = $"{_site.BaseUrl}/#website",
                        url = _site.BaseUrl,
                        name = _site.Name,
                        description = _site.Description,
                        publisher = new { @id = $"{_site.BaseUrl}/#organization" }
                    }
                }
            };

            return JsonSerializer.Serialize(schema);
        }

        public string GetBreadcrumbSchema(string pageName, string pagePath)
        {
            var breadcrumb = new
            {
                @context = "https://schema.org",
                @type = "BreadcrumbList",
                itemListElement = new[]
                {
                    new { @type = "ListItem", position = 1, name = "Home", item = _site.BaseUrl },
                    new { @type = "ListItem", position = 2, name = pageName, item = $"{_site.BaseUrl}{pagePath}" }
                }
            };
            return JsonSerializer.Serialize(breadcrumb);
        }

        public string GetOrganizationSchema()
        {
            var organization = new
            {
                @context = "https://schema.org",
                @type = _business.BusinessTypes,
                name = _business.LegalName,
                url = _site.BaseUrl,
                logo = $"{_site.BaseUrl}/img/logo-company-name-horizontal-dark.png",
                description = _site.Description,
                telephone = _business.Telephone,
                email = _business.Email,
                address = new {
                    @type = "PostalAddress",
                    streetAddress = _business.Address.StreetAddress,
                    addressLocality = _business.Address.AddressLocality,
                    addressRegion = _business.Address.AddressRegion,
                    postalCode = _business.Address.PostalCode,
                    addressCountry = _business.Address.AddressCountry
                },
                areaServed = _business.AreasServed.Select(a => new { 
                    @type = a.Type == "City" ? "City" : "AdministrativeArea", 
                    name = a.Name 
                })
            };
            return JsonSerializer.Serialize(organization);
        }

        public string GetServiceSchema(ServiceInfo service)
        {
            var serviceSchema = new
            {
                @context = "https://schema.org",
                @type = "Service",
                name = service.Name,
                description = service.Description,
                provider = new {
                    @type = "LocalBusiness",
                    name = _business.LegalName,
                    url = _site.BaseUrl
                },
                areaServed = _business.AreasServed.Select(a => a.Name),
                serviceType = service.Category
            };
            return JsonSerializer.Serialize(serviceSchema);
        }

        public string GetContactPageSchema()
        {
            var contactSchema = new
            {
                @context = "https://schema.org",
                @type = "ContactPage",
                name = "Contact Simple Cyber Technology",
                description = "Get in touch with our team to discuss your cybersecurity needs",
                publisher = new {
                    @type = "Organization",
                    name = _business.LegalName,
                    url = _site.BaseUrl,
                    telephone = _business.Telephone,
                    email = _business.Email
                }
            };
            return JsonSerializer.Serialize(contactSchema);
        }

        public string GetFAQSchema(string question, string answer)
        {
            var faqSchema = new
            {
                @context = "https://schema.org",
                @type = "FAQPage",
                mainEntity = new {
                    @type = "Question",
                    name = question,
                    acceptedAnswer = new {
                        @type = "Answer",
                        text = answer
                    }
                }
            };
            return JsonSerializer.Serialize(faqSchema);
        }

        public string GetFAQPageSchema(List<(string question, string answer)> faqs)
        {
            var faqSchema = new
            {
                @context = "https://schema.org",
                @type = "FAQPage",
                mainEntity = faqs.Select(faq => new {
                    @type = "Question",
                    name = faq.question,
                    acceptedAnswer = new {
                        @type = "Answer",
                        text = faq.answer
                    }
                }).ToArray()
            };
            return JsonSerializer.Serialize(faqSchema);
        }

        public string GetLocationSpecificSchema(string cityName, string citySlug)
        {
            var locationSchema = new
            {
                @context = "https://schema.org",
                @type = "LocalBusiness",
                name = $"{_business.LegalName} - {cityName}",
                description = $"Cybersecurity services and help desk support for {cityName} businesses. Local, expert protection from Simple Cyber Technology.",
                url = $"{_site.BaseUrl}/services/{citySlug}",
                telephone = _business.Telephone,
                email = _business.Email,
                address = new
                {
                    @type = "PostalAddress",
                    streetAddress = _business.Address.StreetAddress,
                    addressLocality = _business.Address.AddressLocality,
                    addressRegion = _business.Address.AddressRegion,
                    postalCode = _business.Address.PostalCode,
                    addressCountry = _business.Address.AddressCountry
                },
                areaServed = new {
                    @type = "City",
                    name = cityName
                },
                serviceScopeDescription = $"We provide cybersecurity and IT support services to businesses throughout {cityName} and Southern California.",
                serviceArea = _business.AreasServed.Select(a => new { @type = a.Type, name = a.Name })
            };
            return JsonSerializer.Serialize(locationSchema);
        }

        public string GetWebPageSchema(string pageName, string description)
        {
            var webPageSchema = new
            {
                @context = "https://schema.org",
                @type = "WebPage",
                name = pageName,
                description = description,
                publisher = new
                {
                    @type = "Organization",
                    name = _business.LegalName,
                    url = _site.BaseUrl
                }
            };
            return JsonSerializer.Serialize(webPageSchema);
        }

        public string GetAboutPageSchema()
        {
            var aboutPageSchema = new
            {
                @context = "https://schema.org",
                @type = "AboutPage",
                name = "About Simple Cyber Technology",
                description = "Learn about Simple Cyber Technology, your trusted cybersecurity and IT support partner for Southern California businesses. Founded to make enterprise-grade security accessible and affordable.",
                mainEntity = new
                {
                    @type = "Organization",
                    name = _business.LegalName,
                    url = _site.BaseUrl,
                    foundingDate = "2024",
                    description = "A cybersecurity and IT services company dedicated to protecting small and medium-sized businesses in Southern California."
                }
            };
            return JsonSerializer.Serialize(aboutPageSchema);
        }

        public string GetServicesCollectionSchema()
        {
            var servicesCollection = new
            {
                @context = "https://schema.org",
                @type = "CollectionPage",
                name = "Cybersecurity & IT Services Overview",
                description = "Explore our comprehensive suite of cybersecurity, managed IT, help desk support, and penetration testing services designed for Southern California small and medium-sized businesses.",
                hasPart = new object[]
                {
                    new {
                        @type = "Service",
                        @id = $"{_site.BaseUrl}/services-overview#HelpDesk",
                        name = "Help Desk Support",
                        description = "Friendly, fast IT support when you need it. Real people, real solutions for your technology issues.",
                        provider = new {
                            @type = "Organization",
                            @id = $"{_site.BaseUrl}/#organization",
                            name = _business.LegalName
                        },
                        areaServed = _business.AreasServed.Select(a => a.Name),
                        serviceType = "Technical Support"
                    },
                    new {
                        @type = "Service",
                        @id = $"{_site.BaseUrl}/services-overview#Cybersecurity",
                        name = "Managed Cybersecurity",
                        description = "Enterprise-grade cybersecurity protection with advanced threat detection, proactive system management, data protection, and email & web security.",
                        provider = new {
                            @type = "Organization",
                            @id = $"{_site.BaseUrl}/#organization",
                            name = _business.LegalName
                        },
                        areaServed = _business.AreasServed.Select(a => a.Name),
                        serviceType = "Security Services"
                    },
                    new {
                        @type = "Service",
                        @id = $"{_site.BaseUrl}/services-overview#PenetrationTesting",
                        name = "Penetration Testing",
                        description = "Ethical hacking and security assessments to find vulnerabilities before attackers do. Actionable insights to strengthen your defenses.",
                        provider = new {
                            @type = "Organization",
                            @id = $"{_site.BaseUrl}/#organization",
                            name = _business.LegalName
                        },
                        areaServed = _business.AreasServed.Select(a => a.Name),
                        serviceType = "Security Assessment"
                    }
                }
            };
            return JsonSerializer.Serialize(servicesCollection);
        }

        public string GetLocalBusinessSchema()
        {
            var localBusinessSchema = new
            {
                @context = "https://schema.org",
                @type = "LocalBusiness",
                @id = $"{_site.BaseUrl}/#organization",
                name = _business.LegalName,
                image = $"{_site.BaseUrl}/img/logo-company-name-horizontal-dark.png",
                description = $"Contact {_business.LegalName} for cybersecurity services, help desk support, and IT solutions in Southern California.",
                url = $"{_site.BaseUrl}/contact-us",
                telephone = _business.Telephone,
                email = _business.Email,
                address = new
                {
                    @type = "PostalAddress",
                    streetAddress = _business.Address.StreetAddress,
                    addressLocality = _business.Address.AddressLocality,
                    addressRegion = _business.Address.AddressRegion,
                    postalCode = _business.Address.PostalCode,
                    addressCountry = _business.Address.AddressCountry
                },
                openingHoursSpecification = _business.OpeningHours.Select(h => new
                {
                    @type = "OpeningHoursSpecification",
                    dayOfWeek = h.DaysOfWeek,
                    opens = h.Opens,
                    closes = h.Closes
                })
            };
            return JsonSerializer.Serialize(localBusinessSchema);
        }

        public string GetGlossarySchema(List<GlossaryTerm> terms)
        {
            var glossarySchema = new
            {
                @context = "https://schema.org",
                @type = "DefinedTermSet",
                name = "Cybersecurity & IT Security Glossary",
                description = "A comprehensive glossary of cybersecurity, network security, and IT terms explained in plain language for small and medium-sized business owners.",
                inDefinedTermSet = $"{_site.BaseUrl}/glossary",
                publisher = new
                {
                    @type = "Organization",
                    name = _business.LegalName,
                    url = _site.BaseUrl
                },
                hasDefinedTerm = terms.Select(term => new
                {
                    @type = "DefinedTerm",
                    name = term.Term,
                    description = term.Definition,
                    identifier = $"{_site.BaseUrl}/glossary#term-{term.Term.Replace(" ", "-").ToLower()}"
                }).ToArray()
            };
            return JsonSerializer.Serialize(glossarySchema);
        }
    }
}
