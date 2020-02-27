using System.Collections.Generic;

namespace MakanalTech.Utilities.RazorEmails.Services
{
    // Applied setttings to emails generated in Razor. Applies to all emails
    // sent by the application.
    public class RazorEmailOptions
    {
        // Source url of logo image.
        public string LogoSourceUrl { get; set; }
        // Link when logo is clicked.
        public string LogoTargetUrl { get; set; }
        // Desired width of logo image in px (i.e. '100px').
        public string LogoWidth { get; set; }
        // Inline quick links in the email footer.
        public List<RazorEmailNavLink> FooterLinks { get; set; }
        // Unsubscribe text and link in the footer.
        public string FooterUnsub { get; set; }
        // Footer text in body font (i.e. address, copyright).
        public string FooterText { get; set; }
        // Footer text in small font (i.e. confidentiality notice).
        public string FooterSmallText { get; set; }
    }

    public class RazorEmailNavLink
    {
        public string Url { get; set; }
        public string Text { get; set; }
    }
}