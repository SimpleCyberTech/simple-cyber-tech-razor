using Microsoft.AspNetCore.Mvc.RazorPages;
using simplecybertech.Models;

namespace simplecybertech.Pages;

public class FAQModel : PageModel
{
    public List<FAQItem> FAQs { get; set; } = [];

    public void OnGet()
    {
        FAQs = GetFAQData();
    }

    private static List<FAQItem> GetFAQData()
    {
        return
        [
            new FAQItem
            {
                Id = 1,
                Question = "What cybersecurity services do you offer?",
                Answer = """
                    <p>We offer four core cybersecurity services:</p>
                    <ol>
                        <li><strong>Managed Cybersecurity</strong> - 24/7 monitoring and threat detection with enterprise-grade protection</li>
                        <li><strong>Help Desk Support</strong> - Immediate technical assistance from real people who understand your business</li>
                        <li><strong>Penetration Testing</strong> - Ethical hacking to identify vulnerabilities before attackers do</li>
                        <li><strong>Advanced Threat Detection</strong> - Enterprise-grade EDR (Endpoint Detection and Response) solutions</li>
                    </ol>
                    <p>Each service is tailored to small and medium-sized businesses in Southern California. <a href="/services-overview">Learn more about our services</a>.</p>
                    """
            },
            new FAQItem
            {
                Id = 2,
                Question = "How quickly do you respond to security incidents?",
                Answer = """
                    <p>Response times depend on your Service Level Agreement (SLA). Here's what to expect:</p>
                    <ul>
                        <li><strong>Critical incidents:</strong> Response within 1-2 hours</li>
                        <li><strong>High priority:</strong> Response within 4 hours</li>
                        <li><strong>Standard issues:</strong> Response within 8 business hours</li>
                    </ul>
                    <p>Our Security Operations Center (SOC) monitors systems 24/7/365 to ensure rapid detection and immediate response.</p>
                    """
            },
            new FAQItem
            {
                Id = 3,
                Question = "Do you offer 24/7 monitoring?",
                Answer = """
                    <p>Yes, our managed cybersecurity services include <strong>24/7 Security Operations Center (SOC) monitoring</strong>. This means:</p>
                    <ul>
                        <li>Your systems are constantly watched for threats</li>
                        <li>Our team responds immediately to suspicious activity</li>
                        <li>Monitoring happens 24 hours a day, 7 days a week, 365 days a year</li>
                        <li>No gaps in coverage, even during nights, weekends, and holidays</li>
                    </ul>
                    <p>This proactive approach helps catch threats early, minimizing potential damage.</p>
                    """
            },
            new FAQItem
            {
                Id = 4,
                Question = "What is penetration testing?",
                Answer = """
                    <p>Penetration testing is <strong>ethical hacking</strong> where our certified security professionals simulate real-world attacks on your systems to find vulnerabilities before actual attackers do.</p>
                    <p><strong>The process includes:</strong></p>
                    <ol>
                        <li>Planning & scoping your systems</li>
                        <li>Active testing using real attack techniques</li>
                        <li>Detailed documentation of findings</li>
                        <li>Actionable remediation recommendations</li>
                        <li>Follow-up testing to verify fixes</li>
                    </ol>
                    <p>Penetration testing is an essential part of a comprehensive security strategy and often required by compliance standards. <a href="/services-overview">Learn more about penetration testing</a>.</p>
                    """
            },
            new FAQItem
            {
                Id = 5,
                Question = "How much does cybersecurity cost?",
                Answer = """
                    <p>Pricing varies based on your specific situation:</p>
                    <ul>
                        <li><strong>Business size</strong> - Number of employees and devices</li>
                        <li><strong>Systems complexity</strong> - Types of systems to protect</li>
                        <li><strong>Service level</strong> - Response times and monitoring depth</li>
                        <li><strong>Industry requirements</strong> - Compliance needs (HIPAA, PCI-DSS, etc.)</li>
                    </ul>
                    <p>We offer customized quotes based on your unique needs. <strong>The best approach?</strong> Schedule a security review where we assess your situation and provide a personalized proposal. <a href="/contact-us">Schedule your security review here</a>.</p>
                    """
            },
            new FAQItem
            {
                Id = 6,
                Question = "What's the difference between penetration testing and vulnerability assessment?",
                Answer = """
                    <p class="pb-3">Both are important, but they serve different purposes:</p>
                    <table class="table table-responsive table-bordered table-dark">
                        <thead>
                            <tr class="table-dark">
                                <th>Aspect</th>
                                <th>Vulnerability Assessment</th>
                                <th>Penetration Testing</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="table-dark">
                                <td><strong>Method</strong></td>
                                <td>Automated scanning</td>
                                <td>Manual testing with expert analysis</td>
                            </tr>
                            <tr class="table-dark">
                                <td><strong>Depth</strong></td>
                                <td>Identifies known vulnerabilities</td>
                                <td>Tests actual exploitability and impact</td>
                            </tr>
                            <tr class="table-dark">
                                <td><strong>Cost</strong></td>
                                <td>Lower cost</td>
                                <td>Higher cost (more thorough)</td>
                            </tr>
                            <tr class="table-dark">
                                <td><strong>Best for</strong></td>
                                <td>Baseline security posture</td>
                                <td>Comprehensive security verification</td>
                            </tr>
                        </tbody>
                    </table>
                    <p>Many organizations use both: regular vulnerability assessments for baseline checks, and annual penetration testing for comprehensive verification.</p>
                    """
            },
            new FAQItem
            {
                Id = 7,
                Question = "How do you handle data breaches?",
                Answer = """
                    <p>Our incident response process is swift and comprehensive:</p>
                    <ol>
                        <li><strong>Immediate Detection</strong> - Our 24/7 SOC catches suspicious activity</li>
                        <li><strong>Rapid Containment</strong> - We isolate affected systems to stop the breach</li>
                        <li><strong>Investigation</strong> - We determine what happened, what was accessed, and how the breach occurred</li>
                        <li><strong>Notification</strong> - We notify affected parties as required by law (CCPA, GDPR, etc.)</li>
                        <li><strong>Remediation</strong> - We fix vulnerabilities and implement improvements to prevent recurrence</li>
                        <li><strong>Follow-up</strong> - We verify that fixes are effective and provide recommendations for future prevention</li>
                    </ol>
                    <p>Time is critical in breaches. Our rapid response capability significantly reduces the impact and cost of incidents.</p>
                    """
            },
            new FAQItem
            {
                Id = 8,
                Question = "Are you compliant with HIPAA, PCI-DSS, SOC 2, or NIST?",
                Answer = """
                    <p>We design and implement security services that help our clients comply with major industry standards:</p>
                    <ul>
                        <li><strong>HIPAA</strong> - Healthcare industry data protection</li>
                        <li><strong>PCI-DSS</strong> - Payment card industry compliance</li>
                        <li><strong>SOC 2</strong> - Service organization controls for data security</li>
                        <li><strong>NIST Cybersecurity Framework</strong> - Government and critical infrastructure standards</li>
                        <li><strong>GDPR/CCPA</strong> - Data privacy regulations</li>
                    </ul>
                    <p>Our compliance consulting services help you understand requirements and implement necessary controls. <a href="/contact-us">Contact us to discuss your specific compliance needs</a>.</p>
                    """
            },
            new FAQItem
            {
                Id = 9,
                Question = "How often should we conduct security awareness training?",
                Answer = """
                    <p><strong>Industry best practice:</strong> At least annually, with additional training for specific situations.</p>
                    <p><strong>Recommended training schedule:</strong></p>
                    <ul>
                        <li><strong>Annual:</strong> Required by most regulations (HIPAA, PCI-DSS, etc.)</li>
                        <li><strong>Quarterly:</strong> Refresher training keeps security top-of-mind</li>
                        <li><strong>Post-incident:</strong> After any security breach or near-miss</li>
                        <li><strong>Policy changes:</strong> When new security policies are implemented</li>
                        <li><strong>New employees:</strong> During onboarding</li>
                    </ul>
                    <p>Human error is the leading cause of data breaches. Regular training significantly reduces this risk and is one of the most cost-effective security investments.</p>
                    """
            },
            new FAQItem
            {
                Id = 10,
                Question = "What happens if there's a security issue outside business hours?",
                Answer = """
                    <p>Security doesn't work 9-to-5, and neither do we.</p>
                    <ul>
                        <li><strong>24/7 Monitoring:</strong> Our SOC continuously monitors for threats at all times</li>
                        <li><strong>Immediate Detection:</strong> Threats are detected automatically, regardless of the time</li>
                        <li><strong>Rapid Response:</strong> Our on-call team responds immediately to critical incidents</li>
                        <li><strong>Emergency Support:</strong> For urgent help desk issues, we have different options available for on call support</li>
                    </ul>
                    <p>Nights, weekends, and holidays are no exception. We're always watching.</p>
                    """
            },
            new FAQItem
            {
                Id = 11,
                Question = "Do you work with businesses outside Orange County?",
                Answer = """
                    <p>Yes! While we're based in Costa Mesa and specialize in serving Southern California businesses, we work with clients throughout:</p>
                    <ul>
                        <li>Orange County (all cities)</li>
                        <li>Los Angeles County</li>
                        <li>San Diego County</li>
                        <li>Riverside County</li>
                        <li>San Bernardino County</li>
                        <li>And beyond</li>
                    </ul>
                    <p>Our local presence allows us to provide personalized service with the flexibility to serve remote clients. Whether you're in our backyard or across Southern California, we're here to help.</p>
                    """
            },
            new FAQItem
            {
                Id = 12,
                Question = "How do I get started with Simple Cyber Technology?",
                Answer = """
                    <p>Getting started is simple:</p>
                    <ol>
                        <li><strong>Schedule a free security review</strong> at your convenience</li>
                        <li><strong>Assessment:</strong> Our team assesses your current security posture and needs</li>
                        <li><strong>Proposal:</strong> We provide a customized proposal with recommendations</li>
                        <li><strong>Implementation:</strong> Upon agreement, we implement our services</li>
                    </ol>
                    <p><strong>Ready to get started?</strong></p>
                    <ul>
                        <li>Call: <a href="tel:9495206805">(949) 520-6805</a></li>
                        <li>Or <a href="/contact-us">schedule a security review online</a></li>
                    </ul>
                    """
            },
            new FAQItem
            {
                Id = 13,
                Question = "What makes Simple Cyber Technology different?",
                Answer = """
                    <p>We focus on three key differentiators that set us apart:</p>
                    <ol>
                        <li><strong>Clarity</strong> - We explain everything in plain English, not technical jargon. You'll always understand what we're doing and why.</li>
                        <li><strong>Local</strong> - We're Orange County-based and understand the unique needs of local businesses. We're not a faceless enterprise.</li>
                        <li><strong>Accountability</strong> - We're transparent about what we do, stand behind our work, and provide clear metrics and results.</li>
                    </ol>
                    <p>We're not trying to upsell you unnecessary services. We're your trusted security partner, committed to your success. <a href="/about-us">Learn more about our values</a>.</p>
                    """
            }
        ];
    }

    public static string StripHtmlTags(string html)
    {
        if (string.IsNullOrEmpty(html))
            return string.Empty;

        // Remove HTML tags and normalize whitespace for schema
        var text = System.Text.RegularExpressions.Regex.Replace(html, "<.*?>", " ");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " ");
        return text.Trim();
    }

    public List<(string question, string answer)> GetFAQSchemaData()
    {
        return FAQs.Select(faq => (faq.Question, StripHtmlTags(faq.Answer))).ToList();
    }
}
