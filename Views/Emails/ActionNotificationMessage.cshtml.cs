namespace MakanalTech.Utilities.RazorEmails.Views.Emails
{
    public class ActionNotificationMessage
    {
        public ActionNotificationMessage(string message)
        {
            Message = message;
        }

        public string CallbackUrl { get; set; }
        public string CallbackAction { get; set; }
        public string Message { get; set; }
        public string EmailTitle { get; set; }
        public string PreheaderText { get; set; }
    }
}