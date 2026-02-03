namespace simplecybertech.Models
{
    public class SiteSettings
    {
        public required string BaseUrl { get; set; }
        public required string Name { get; set; }
        public required string Tagline { get; set; }
        public required string Description { get; set; }
        public required string Language { get; set; }
        public required string CopyrightYear { get; set; }
    }

    public class BusinessInfo
    {
        public required string LegalName { get; set; }
        public required List<string> BusinessTypes { get; set; }
        public required string Telephone { get; set; }
        public required string TelephoneDisplay { get; set; }
        public required string Email { get; set; }
        public required AddressInfo Address { get; set; }
        public required List<OpeningHourInfo> OpeningHours { get; set; }
        public required List<AreaServedInfo> AreasServed { get; set; }
        public required List<string> KnowsAbout { get; set; }
    }

    public class AddressInfo
    {
        public required string StreetAddress { get; set; }
        public required string AddressLocality { get; set; }
        public required string AddressRegion { get; set; }
        public required string PostalCode { get; set; }
        public required string AddressCountry { get; set; }
    }

    public class OpeningHourInfo
    {
        public required List<string> DaysOfWeek { get; set; }
        public required string Opens { get; set; }
        public required string Closes { get; set; }
    }

    public class AreaServedInfo
    {
        public required string Type { get; set; }
        public required string Name { get; set; }
    }

    public class ServiceInfo
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Url { get; set; }
        public required string Category { get; set; }
    }

    public class NavigationSettings
    {
        public required string HomePage { get; set; }
        public required string AboutPage { get; set; }
        public required string ServicesPage { get; set; }
        public required string ContactPage { get; set; }
        public required string SchedulePage { get; set; }
        public required string PrivacyPolicyPage { get; set; }
        public required string TermsOfServicePage { get; set; }
    }
}