using MailingList.Models;
using Microsoft.AspNetCore.Mvc;

namespace MailingList.Controllers;

[ApiController]
[Route("[controller]")]
public class MailingListController : ControllerBase
{

    private static readonly MailListEntry[] MailListEntries = new[]
    {
        new MailListEntry("Todd", "Howard", "thoward@gmail.com"),
        new MailListEntry("Amy", "Linscomb", "alinscomb@gmail.com"),
        new MailListEntry("Bart", "Simpson", "bartSimps@gmail.com"),
        new MailListEntry("Tim", "Cook", "Tcook@Apple.com"),
        new MailListEntry("Samantha", "Laird", "samlaird@hotmail.com"),
        new MailListEntry("George", "Laird", "georgieLaird@hotmail.com"),
        new MailListEntry("Amanda", "Acron", "AmandatheAcorn@gmail.com"),
    };


    public MailingListController() {}

    [HttpGet(Name = "MailingList")]
    public IEnumerable<MailListEntry> Get(string lastName = "", bool ascending = true)
    {
        var returnEntries = MailListEntries.Where(entry => string.Equals(entry.LastName, lastName, StringComparison.CurrentCultureIgnoreCase) || lastName == "");
        returnEntries = ascending ? returnEntries.OrderBy(entry => entry.LastName).ThenBy(entry => entry.FirstName) : returnEntries.OrderByDescending(entry => entry.LastName).ThenByDescending(entry => entry.FirstName);
        return returnEntries;
    }
}