namespace Domain
{
    /// <summary>
    /// This type is used to store the developer data used for testing during development. 
    /// Currently only the the email is being used for development time emails but other properties can be added as needed.
    /// </summary>
    public record DevUser(int Id, string ToEmailAddress);
}
