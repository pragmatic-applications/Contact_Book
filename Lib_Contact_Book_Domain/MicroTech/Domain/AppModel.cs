namespace Domain
{
    /// <summary>
    /// This type is used to store the data required for the client App owner's data such Mail server info and where to send emails when contacted.
    /// </summary>
    public record AppModel(int Id, string SmtpServer, string MailServerUserName, string MailServerUserPassword, string ToEmailAddress);
}
