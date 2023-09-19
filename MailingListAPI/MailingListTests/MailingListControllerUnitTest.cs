namespace MailingListTests;

public class Tests
{
    // check the return value when a last name is passed through the parameters
    [Test]
    public void LastNameTest()
    {
        var controller = new MailingListController();
        var result = controller.Get("Cook");
        var comparison = new MailListEntry("Tim", "Cook", "Tcook@Apple.com");
        Assert.Pass(comparison.ToString(), result.First());
    }
    // check the return value to ensure correct sorting when no parameters are passed
    [Test]
    public void SortAscendingTest()
    {
        var controller = new MailingListController();
        var result = controller.Get();
        var resArray = result.ToArray();
        var resArraySorted = resArray.OrderBy(entry => entry.LastName).ThenBy(entry => entry.FirstName).ToArray();
        CollectionAssert.AreEqual(resArraySorted, resArray);
    }
    // check the return value to ensure correct sorting when no ascending parameter is set to false
    [Test]
    public void SortDescendingTest()
    {
        var controller = new MailingListController();
        var result = controller.Get(ascending: false);
        var resArray = result.ToArray();
        var resArraySorted = resArray.OrderByDescending(entry => entry.LastName).ThenByDescending(entry => entry.FirstName).ToArray();
        CollectionAssert.AreEqual(resArraySorted, resArray);
    }
    // check the return value to ensure correct sorting when a last name is passed and it is sorted descending
    [Test]
    public void LastNameSortDescendingTest()
    {
        var controller = new MailingListController();
        var result = controller.Get(lastName:"Laird", ascending: false);
        var resArray = result.ToArray();
        var resArraySorted = resArray.OrderByDescending(entry => entry.LastName).ThenByDescending(entry => entry.FirstName).ToArray();
        CollectionAssert.AreEqual(resArraySorted, resArray);
    }

}