using Microsoft.AspNetCore.Mvc.RazorPages;
using simplecybertech.Models;

namespace simplecybertech.Pages;

public class GlossaryModel : PageModel
{
    public List<GlossaryTerm> GlossaryTerms { get; set; } = [];
    public Dictionary<char, List<GlossaryTerm>> TermsByLetter { get; set; } = [];

    public void OnGet()
    {
        GlossaryTerms = GetGlossaryData();
        TermsByLetter = GlossaryTerms
            .GroupBy(t => t.Letter)
            .OrderBy(g => g.Key)
            .ToDictionary(g => g.Key, g => g.ToList());
    }

    private static List<GlossaryTerm> GetGlossaryData()
    {
        return
        [
            // A
            new GlossaryTerm
            {
                Letter = 'A',
                Term = "Advanced Threat Detection (ATD)",
                Definition = "A security technology that goes beyond basic antivirus to identify sophisticated attacks. It uses behavioral analysis and machine learning to detect threats that look like normal activity but are actually malicious. Essential for catching zero-day exploits and advanced persistent threats (APTs)."
            },
            new GlossaryTerm
            {
                Letter = 'A',
                Term = "Antivirus Software",
                Definition = "A program designed to prevent, detect, and remove malware (malicious software) from your computer. Traditional antivirus looks for known threats; modern antivirus also uses behavioral analysis to catch new threats. However, antivirus alone is not sufficient for comprehensive security."
            },
            new GlossaryTerm
            {
                Letter = 'A',
                Term = "Authentication",
                Definition = "The process of verifying that someone is who they claim to be. In security, this typically involves passwords, but stronger authentication uses multiple factors: something you know (password), something you have (phone or security key), or something you are (fingerprint). Multi-factor authentication (MFA) is more secure than passwords alone."
            },

            // B
            new GlossaryTerm
            {
                Letter = 'B',
                Term = "Backup",
                Definition = "A copy of your data stored separately from the original. Regular backups are your insurance against data loss from ransomware, hardware failure, or accidents. Best practice: follow the 3-2-1 rule: 3 copies of data, 2 different storage types, 1 copy offsite. Backups should be tested regularly to ensure they can actually be restored."
            },
            new GlossaryTerm
            {
                Letter = 'B',
                Term = "Botnet",
                Definition = "A network of compromised computers controlled by an attacker without the owners' knowledge. Each infected computer (a \"bot\") can be used to send spam, launch attacks, or steal data. Botnets often spread through malware or unpatched vulnerabilities."
            },
            new GlossaryTerm
            {
                Letter = 'B',
                Term = "Brute Force Attack",
                Definition = "A hacking technique where an attacker tries many password combinations until they find the right one. Like trying every key on a keyring to open a lock. Defenses include: strong passwords, account lockouts after failed attempts, and rate limiting. This is why \"Password123!\" is worse than \"correct-horse-battery-staple\"."
            },

            // C
            new GlossaryTerm
            {
                Letter = 'C',
                Term = "Compliance",
                Definition = "Following rules and regulations that apply to your industry. Examples: HIPAA (healthcare), PCI-DSS (payment cards), GDPR (EU privacy), SOC 2 (service providers). Compliance is not just about avoiding fines; it means implementing security controls that protect your business and your customers' data."
            },
            new GlossaryTerm
            {
                Letter = 'C',
                Term = "Cybersecurity",
                Definition = "The practice of protecting computer systems, networks, and data from unauthorized access, theft, or damage. Cybersecurity includes technology (firewalls, encryption), processes (security policies), and people (training, awareness)."
            },
            new GlossaryTerm
            {
                Letter = 'C',
                Term = "Cyber Threat",
                Definition = "Any potential danger to your digital assets: data, systems, networks, or reputation. Threats can be intentional (hackers, competitors) or accidental (employee mistakes, hardware failure). A threat is the potential for harm; a vulnerability is a weakness that could be exploited; and risk is the likelihood and impact of that happening."
            },
            new GlossaryTerm
            {
                Letter = 'C',
                Term = "Cybersecurity Insurance",
                Definition = "Also called cyber liability insurance. Coverage for costs related to data breaches, ransomware attacks, business interruption, and legal liability. Insurance is NOT a substitute for security controls, but it helps recover from incidents. Most insurers require certain security measures before providing coverage."
            },

            // D
            new GlossaryTerm
            {
                Letter = 'D',
                Term = "Data Breach",
                Definition = "Unauthorized access to sensitive information, usually resulting in data theft or exposure. A breach may be discovered immediately or months later. Under regulations like GDPR and CCPA, you must notify affected parties within specific timeframes. Prevention is far cheaper than managing a breach."
            },
            new GlossaryTerm
            {
                Letter = 'D',
                Term = "DDoS Attack (Distributed Denial of Service)",
                Definition = "A cyberattack where multiple computers flood a website or service with requests, overwhelming it and making it unavailable to legitimate users. It's like thousands of people trying to enter a store at once, blocking the door. DDoS protection monitors traffic patterns and filters out malicious requests."
            },
            new GlossaryTerm
            {
                Letter = 'D',
                Term = "Disaster Recovery Plan (DRP)",
                Definition = "A documented process for how your business will continue operating after a major incident: data breach, ransomware, natural disaster, or service failure. It includes backups, alternative systems, communication plans, and recovery time objectives (RTO). Every business should have one."
            },

            // E
            new GlossaryTerm
            {
                Letter = 'E',
                Term = "Encryption",
                Definition = "Scrambling data using mathematical algorithms so only authorized people with the encryption key can read it. Encryption protects data in transit (HTTPS on websites) and at rest (encrypted files). Even if a hacker steals encrypted data, they can't read it without the key."
            },
            new GlossaryTerm
            {
                Letter = 'E',
                Term = "Endpoint",
                Definition = "Any device connected to your network: computers, laptops, phones, tablets, printers, IoT devices. Each endpoint is a potential security risk if not protected. Endpoint security includes antivirus, firewalls, encryption, and monitoring."
            },
            new GlossaryTerm
            {
                Letter = 'E',
                Term = "Endpoint Detection and Response (EDR)",
                Definition = "Advanced security software installed on individual devices (endpoints) that continuously monitors for suspicious behavior and responds to threats. EDR goes beyond antivirus by using AI and behavioral analysis to catch sophisticated attacks. It's like a security team watching each computer 24/7."
            },

            // F
            new GlossaryTerm
            {
                Letter = 'F',
                Term = "Firewall",
                Definition = "A security barrier that monitors and controls network traffic coming in and out of your network. A firewall is like a border guard checking passports. It blocks unauthorized access while allowing legitimate traffic. Most businesses use both network firewalls (at the router) and personal firewalls (on each device)."
            },
            new GlossaryTerm
            {
                Letter = 'F',
                Term = "Firmware",
                Definition = "Software that controls how hardware devices work. Examples: router firmware, printer firmware, device firmware. Firmware can have vulnerabilities, so it's critical to keep it updated. Many security breaches start with unpatched firmware."
            },

            // G
            new GlossaryTerm
            {
                Letter = 'G',
                Term = "GDPR (General Data Protection Regulation)",
                Definition = "European Union regulation that protects personal data of EU residents. Even if your business is in the US, GDPR applies if you handle EU customer data. Requirements include obtaining consent, data privacy, breach notification, and user rights. Non-compliance fines reach €20 million or 4% of annual revenue."
            },
            new GlossaryTerm
            {
                Letter = 'G',
                Term = "Hacker",
                Definition = "Someone who gains unauthorized access to computer systems. Not all hackers are criminals: \"white hat\" hackers help find vulnerabilities; \"black hat\" hackers steal data or cause harm; \"gray hat\" hackers operate in gray areas. Cybersecurity professionals are ethical hackers who help organizations find and fix problems."
            },

            // H
            new GlossaryTerm
            {
                Letter = 'H',
                Term = "HIPAA (Health Insurance Portability and Accountability Act)",
                Definition = "US law protecting patient health information. If you work in healthcare, you must implement HIPAA-compliant security: access controls, encryption, audit logs, breach notification. Violations carry fines up to $50,000 per incident."
            },
            new GlossaryTerm
            {
                Letter = 'H',
                Term = "HTTPS",
                Definition = "Secure version of HTTP (web protocol) that encrypts data between your browser and a website. Look for the padlock icon in your browser. HTTPS uses SSL/TLS encryption, so eavesdroppers can't see your passwords or personal information. Any website handling sensitive data should use HTTPS."
            },

            // I
            new GlossaryTerm
            {
                Letter = 'I',
                Term = "Identity and Access Management (IAM)",
                Definition = "Systems and policies that control who can access what resources. IAM answers: Who is this person? What are they allowed to do? Are they still supposed to have access? Includes user provisioning, password management, multi-factor authentication, and access reviews."
            },
            new GlossaryTerm
            {
                Letter = 'I',
                Term = "Incident Response",
                Definition = "Your plan for responding to a security breach or cyberattack. Includes: detection, containment, investigation, eradication, and recovery. Fast incident response minimizes damage and cost. Every organization should have an incident response plan and practice it regularly."
            },
            new GlossaryTerm
            {
                Letter = 'I',
                Term = "IoT (Internet of Things)",
                Definition = "Connected devices beyond traditional computers: smart devices, cameras, sensors, industrial equipment. IoT devices can be convenient but are often security weaknesses. Many lack strong passwords, don't receive security updates, and collect personal data. Secure your IoT devices with network segmentation and monitoring."
            },

            // M
            new GlossaryTerm
            {
                Letter = 'M',
                Term = "Malware",
                Definition = "Malicious software designed to harm your computer or steal data. Types include viruses (replicate by infecting files), worms (spread across networks), trojans (disguise as legitimate programs), spyware (steal information), and ransomware (encrypt and extort). Prevention: antivirus, patches, user training."
            },
            new GlossaryTerm
            {
                Letter = 'M',
                Term = "Multi-Factor Authentication (MFA)",
                Definition = "Security that requires multiple forms of proof of identity. Examples: password (something you know) + phone approval (something you have). Even if someone steals your password, they can't access your account without your phone. MFA dramatically reduces the risk of account takeover."
            },
            new GlossaryTerm
            {
                Letter = 'M',
                Term = "Managed Security Services Provider (MSSP)",
                Definition = "A third-party company that manages your security for you: monitoring networks, managing firewalls, responding to incidents, updating patches. MSSPs allow small businesses to access enterprise-grade security without hiring a large IT team."
            },

            // N
            new GlossaryTerm
            {
                Letter = 'N',
                Term = "Network Segmentation",
                Definition = "Dividing your network into smaller sections (segments or subnets) and controlling traffic between them. Think of it as doors in a building: if one area is breached, the attacker doesn't have access to the entire network. Segments might include: admin network, employee network, guest network, production systems."
            },
            new GlossaryTerm
            {
                Letter = 'N',
                Term = "NIST Cybersecurity Framework",
                Definition = "A set of guidelines from the US National Institute of Standards and Technology for managing cybersecurity. NIST provides best practices organized into five functions: Identify, Protect, Detect, Respond, and Recover. Used by government agencies and increasingly by businesses."
            },

            // P
            new GlossaryTerm
            {
                Letter = 'P',
                Term = "PCI-DSS (Payment Card Industry Data Security Standard)",
                Definition = "Standard for businesses that accept credit card payments. If you handle card data, you must comply with PCI-DSS: encryption, access controls, regular security testing, incident response. Non-compliance results in fines and card processing bans."
            },
            new GlossaryTerm
            {
                Letter = 'P',
                Term = "Penetration Testing (Pen Testing)",
                Definition = "Authorized security testing where experts simulate real attacks to find vulnerabilities before hackers do. Includes trying to break into networks, exploit software, and compromise systems. Results in a detailed report of findings and recommendations. Annual penetration testing is a best practice."
            },
            new GlossaryTerm
            {
                Letter = 'P',
                Term = "Phishing",
                Definition = "Email or message that tricks you into revealing sensitive information or clicking a malicious link. Example: fake \"confirm your password\" email. Phishing is the leading cause of data breaches. Defense: user training, email filtering, multi-factor authentication. When in doubt, verify with a phone call."
            },
            new GlossaryTerm
            {
                Letter = 'P',
                Term = "Patch Management",
                Definition = "Process of updating software to fix security vulnerabilities and bugs. Patches are released regularly for operating systems, applications, and firmware. Unpatched systems are vulnerable. Strategy: automate patching where possible, test before deploying, keep an inventory of what's installed."
            },
            new GlossaryTerm
            {
                Letter = 'P',
                Term = "Public Key Infrastructure (PKI)",
                Definition = "System for encrypting data and verifying identity using pairs of keys: a public key (shared) and a private key (secret). Used for HTTPS, email encryption, and digital signatures. PKI ensures that data stays confidential and messages are authentic."
            },

            // R
            new GlossaryTerm
            {
                Letter = 'R',
                Term = "Ransomware",
                Definition = "Malware that encrypts your files and demands payment (ransom) to decrypt them. Ransomware spreads through phishing, unpatched vulnerabilities, or compromised credentials. Defense: regular backups (offline), patch management, email security, user training. If infected, consult with cybersecurity experts—paying ransoms funds criminals and doesn't guarantee file recovery."
            },
            new GlossaryTerm
            {
                Letter = 'R',
                Term = "Risk Assessment",
                Definition = "Process of identifying potential threats to your business and evaluating their likelihood and impact. Risk = Threat × Vulnerability × Impact. Assessment helps prioritize what security measures matter most. Should be done annually and after major changes."
            },
            new GlossaryTerm
            {
                Letter = 'R',
                Term = "Risk Management",
                Definition = "Strategy for dealing with identified risks: avoid (don't do risky things), mitigate (reduce risk), transfer (buy insurance), or accept (acknowledge and live with it). Not every risk can be eliminated; the goal is to manage risk to acceptable levels."
            },

            // S
            new GlossaryTerm
            {
                Letter = 'S',
                Term = "Security Awareness Training",
                Definition = "Education for employees about security risks and best practices. Topics: password security, phishing recognition, data handling, incident reporting. Regular training (at least annually, ideally quarterly) significantly reduces the risk of human error leading to breaches. Employees are your first line of defense."
            },
            new GlossaryTerm
            {
                Letter = 'S',
                Term = "SOC 2 Compliance",
                Definition = "Security certification for service providers (cloud, SaaS, hosting companies). SOC 2 assesses controls in five areas: security, availability, processing integrity, confidentiality, and privacy. If your vendors handle sensitive data, ask for their SOC 2 certification."
            },
            new GlossaryTerm
            {
                Letter = 'S',
                Term = "Social Engineering",
                Definition = "Manipulation of people to bypass security controls. Attacker might pretend to be IT support and ask for your password. Social engineering exploits human psychology rather than technical vulnerabilities. Defense: verify identities, follow security policies, trust your instincts, report suspicious requests."
            },
            new GlossaryTerm
            {
                Letter = 'S',
                Term = "SSL/TLS",
                Definition = "Encryption protocols that secure data in transit over the internet. SSL (Secure Sockets Layer) is older; TLS (Transport Layer Security) is the modern standard. They establish encrypted connections (HTTPS websites). Every business website should use TLS."
            },

            // T
            new GlossaryTerm
            {
                Letter = 'T',
                Term = "Threat",
                Definition = "Any potential danger to your systems or data. Threats can be external (hackers, malware) or internal (disgruntled employees, accidental deletion). A threat only becomes a problem if there's a vulnerability to exploit."
            },
            new GlossaryTerm
            {
                Letter = 'T',
                Term = "Threat Intelligence",
                Definition = "Information about current and emerging cyber threats, attack methods, and threat actors. Businesses use threat intelligence to understand what attacks might target them and how to defend against them. Intelligence includes indicators of compromise (IOCs), attack patterns, and attacker information."
            },
            new GlossaryTerm
            {
                Letter = 'T',
                Term = "Two-Factor Authentication (2FA)",
                Definition = "A type of multi-factor authentication requiring two forms of identity verification. Examples: password + phone code, email + security key. Significantly more secure than passwords alone."
            },

            // V
            new GlossaryTerm
            {
                Letter = 'V',
                Term = "Vulnerability",
                Definition = "A weakness in your systems that could be exploited by an attacker. Examples: unpatched software, weak passwords, misconfigured systems, lack of encryption. Vulnerabilities are found through security testing; fixing them is part of your security strategy."
            },
            new GlossaryTerm
            {
                Letter = 'V',
                Term = "Vulnerability Scan",
                Definition = "Automated scan of your systems to identify known vulnerabilities. Vulnerability scans use vulnerability databases (CVE—Common Vulnerabilities and Exposures) to find unpatched software, weak configurations, and other issues. Regular scanning (monthly or quarterly) helps you stay ahead of attackers."
            },
            new GlossaryTerm
            {
                Letter = 'V',
                Term = "Vulnerability Assessment",
                Definition = "More detailed than a scan, a vulnerability assessment uses both automated and manual testing to identify weaknesses, prioritize them, and recommend fixes. Unlike penetration testing, assessments don't exploit vulnerabilities—they just identify them."
            },

            // Z
            new GlossaryTerm
            {
                Letter = 'Z',
                Term = "Zero-Day Exploit",
                Definition = "An attack that exploits a previously unknown vulnerability (one that developers haven't had time to patch). \"Zero-day\" means attackers had zero days to prepare a fix. Zero-day exploits are rare, sophisticated, and dangerous. Defenses include: keep systems up-to-date, use behavior-based detection, limit user privileges."
            },
            new GlossaryTerm
            {
                Letter = 'Z',
                Term = "Zero Trust Security",
                Definition = "Security approach that assumes no user or system is inherently trustworthy, even if they're inside your network. Verify every access request: authentication, device health, data sensitivity. Zero trust requires continuous verification rather than one-time login. It's becoming the industry standard."
            }
        ];
    }
}
