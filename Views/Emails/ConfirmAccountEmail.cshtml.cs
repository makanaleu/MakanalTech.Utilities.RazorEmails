namespace MakanalTech.Utilities.RazorEmails.Views.Emails
{
    public class ConfirmAccountEmailModel
    {
        public ConfirmAccountEmailModel(string callbackUrl)
        {
            ConfirmEmailUrl = callbackUrl;
        }

        public string ConfirmEmailUrl { get; set; }
    }
}