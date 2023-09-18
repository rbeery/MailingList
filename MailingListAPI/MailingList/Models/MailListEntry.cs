namespace MailingList.Models;

public class MailListEntry
{
    public MailListEntry(string first, string last, string email)
    {
        FirstName = first;
        LastName = last;
        EmailAddress = email;
    }
    public string FirstName { get; set; }
    
    public string LastName { get; set; } 
    
    public string EmailAddress { get; set; }
}