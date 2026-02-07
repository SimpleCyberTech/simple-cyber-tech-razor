using Microsoft.AspNetCore.Mvc.RazorPages;
using simplecybertech.Models;

namespace simplecybertech.Pages;

public class ServicesModel : PageModel
{
    public List<FAQItem> ServicesFAQs { get; set; } = [];

    public void OnGet()
    {
        ServicesFAQs = GetServicesFAQData();
    }

    private static List<FAQItem> GetServicesFAQData()
    {
        return
        [
            new FAQItem
            {
                Id = 1,
                Question = "What services does a Cybersecurity MSP like Simple Cyber Technology provide?",
                Answer = """
                    <p class="pb-3">Simple Cyber Technology is a <strong>cybersecurity-first Managed Service Provider (MSP)</strong> that provides a complete safety net for your business by combining <strong>managed IT services</strong>, <strong>cybersecurity</strong>, and <strong>help desk support</strong> into one unified solution. Our goal is to keep your systems reliable, secure, and aligned with your business objectives.</p>
                    <p><strong>Our core managed services include:</strong></p>
                    <ul>
                        <li><strong>24/7 security monitoring and alerting</strong> to detect cyber threats and vulnerabilities in real time</li>
                        <li><strong>Managed IT services</strong> for servers, networks, cloud environments, and user devices</li>
                        <li><strong>Help desk and end-user support</strong> for everyday technical issues and troubleshooting</li>
                        <li><strong>Data backup and disaster recovery</strong> to protect critical business data and support business continuity</li>
                        <li><strong>Cyber risk assessments and security reviews</strong> to identify and reduce your highest areas of risk</li>
                        <li><strong>Compliance and governance support</strong>, including <strong>SAMS</strong> and <strong>DOD vendor</strong> requirements for government contracts</li>
                    </ul>
                    <p>By partnering with Simple Cyber Technology as your <strong>cybersecurity MSP</strong>, you get one team responsible for both protecting and supporting your technology environment.  Thought we still work well with other IT providers, we are a cybersecurity-first MSP and will not try to sell you services you don't need.</p>
                    """
            },
            new FAQItem
            {
                Id = 2,
                Question = "How does Simple Cyber Technology protect businesses from cyber attacks?",
                Answer = """
                    <p class="pb-3">We protect your business using a <strong>layered defense strategy</strong> that applies multiple security controls across your network, devices, users, and data. This approach reduces the likelihood that a single weakness will result in a successful cyber attack.</p>
                    <p><strong>Key elements of our cybersecurity protection include:</strong></p>
                    <ul>
                        <li><strong>Secure network and firewall management</strong> to control and monitor traffic in and out of your environment</li>
                        <li><strong>Endpoint protection and EDR (Endpoint Detection and Response)</strong> on workstations and servers to detect and block malicious behavior</li>
                        <li><strong>Continuous vulnerability scanning and remediation</strong> to identify and fix security gaps before attackers can exploit them</li>
                        <li><strong>Email, identity, and access security</strong>, including phishing protection and multi-factor authentication (MFA)</li>
                        <li><strong>Security awareness training</strong> to help your staff recognize and avoid common cyber threats</li>
                        <li><strong>Compliance-aligned controls</strong> designed to support standards and expectations for <strong>government agencies and contractors</strong>, including <strong>DOD-related security requirements</strong></li>
                    </ul>
                    <p>This combination of managed cybersecurity tools, monitoring, and best practices helps reduce your overall risk and protects your organization from ransomware, data breaches, and other common cyber attacks.</p>
                    """
            },
            new FAQItem
            {
                Id = 3,
                Question = "What is your incident response process during a data breach or security event?",
                Answer = """
                    <p class="pb-3">If a <strong>security incident</strong> or <strong>data breach</strong> occurs, Simple Cyber Technology follows a structured <strong>incident response process</strong> to contain the threat quickly, limit damage, and restore normal operations as safely as possible.</p>
                    <p><strong>Our incident response process typically includes:</strong></p>
                    <ol>
                        <li><strong>Immediate detection and containment</strong> – Identifying the issue and isolating affected systems or accounts</li>
                        <li><strong>Threat neutralization</strong> – Stopping malicious activity and removing any malware or unauthorized access</li>
                        <li><strong>Root-cause investigation</strong> – Analyzing how the incident occurred, what systems were impacted, and what data may be at risk</li>
                        <li><strong>System cleanup and recovery</strong> – Repairing affected systems and restoring clean backups where necessary</li>
                        <li><strong>Post-incident reporting and documentation</strong> – Providing a clear summary of what happened, how it was resolved, and any potential notification or compliance steps</li>
                        <li><strong>Security improvements and hardening</strong> – Updating configurations, controls, and policies to reduce the chance of a similar incident happening again</li>
                    </ol>
                    <p>Throughout the incident, we communicate in clear, straightforward language so leaders and stakeholders understand the situation, impact, and recovery plan without needing deep technical knowledge.</p>
                    """
            },
            new FAQItem
            {
                Id = 4,
                Question = "How much do managed cybersecurity and IT services cost?",
                Answer = """
                    <p class="pb-3">Our <strong>managed cybersecurity and IT services</strong> are billed as a predictable <strong>monthly subscription</strong>, making it easier to budget compared to one-off or hourly "break-fix" support. Pricing is based on the size and complexity of your environment and the level of protection you need.</p>
                    <p><strong>Typical pricing factors include:</strong></p>
                    <ul>
                        <li>Number of <strong>users</strong> and <strong>devices</strong> we manage and protect</li>
                        <li>Number of <strong>locations</strong> and whether you are on-premises, cloud, or hybrid</li>
                        <li>Level of <strong>cybersecurity controls</strong>, monitoring, and response required</li>
                        <li><strong>Compliance requirements</strong> (such as government, DOD, or industry-specific standards)</li>
                        <li>Optional advanced services, such as extended logging, endpoint detection and response (EDR), or 24/7 SOC-style monitoring</li>
                    </ul>
                    <p>We provide a clear proposal that outlines exactly what is included in your <strong>managed services plan</strong>, so you understand how your investment reduces the risk and potential cost of downtime, data loss, and cyber incidents.</p>
                    """
            },
            new FAQItem
            {
                Id = 5,
                Question = "Why choose a Cybersecurity MSP over a traditional IT provider?",
                Answer = """
                    <p class="pb-3">Choosing a <strong>cybersecurity-focused MSP</strong> like Simple Cyber Technology gives your organization a partner that prioritizes <strong>security, risk management, and compliance</strong>, not just basic IT support.</p>
                    <p><strong>Key advantages over a traditional IT provider include:</strong></p>
                    <ul>
                        <li><strong>Proactive monitoring instead of reactive "break-fix" support</strong> – We work to prevent issues before they interrupt your business</li>
                        <li><strong>Security-first mindset</strong> – All technology decisions are evaluated through a cybersecurity and risk lens</li>
                        <li><strong>Integrated cybersecurity and IT management</strong> – One provider responsible for both protecting and operating your environment</li>
                        <li><strong>Support for compliance and government work</strong> – Including <strong>SAMS</strong> and <strong>DOD vendor certifications</strong> and related security expectations</li>
                        <li><strong>Strategic guidance</strong> – Technology and security planning that supports your long-term business goals</li>
                    </ul>
                    <p>By working with a <strong>Cybersecurity MSP</strong>, you move from simply keeping systems running to actively <strong>protecting your data, reputation, and operations</strong> in a constantly changing threat landscape.</p>
                    """
            }
        ];
    }

    public static string StripHtmlTags(string html)
    {
        if (string.IsNullOrEmpty(html))
            return string.Empty;

        var text = System.Text.RegularExpressions.Regex.Replace(html, "<.*?>", " ");
        text = System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " ");
        return text.Trim();
    }

    public List<(string question, string answer)> GetServicesFAQSchemaData()
    {
        return ServicesFAQs.Select(faq => (faq.Question, StripHtmlTags(faq.Answer))).ToList();
    }
}