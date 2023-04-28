using AirEase_AMS.App.Entity.User;
using NUnit.Framework;

namespace AirEase_AMS.App.Ticket.Tests;


[TestFixture]
public class FlightManifestTests
{



    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void PrintManifestTest(int num_customers)
    {
        Customer[] customers = { new Customer("Bob"), new Customer("Richard"), new Customer("Matt") };
        customers[0].SetLastName("Marley");
        customers[1].SetLastName("Nixon");
        customers[2].SetLastName("Shadows");
        string testMan = "";
        FlightManifest tests = new FlightManifest();
        for (int i = 0; i < num_customers; i++)
        {
            tests.AddCustomer(customers[i]);
            testMan +=  ",";
            testMan += customers[i].GetFirstName();
            testMan +=  ",";
            testMan += customers[i].GetLastName();
            testMan +=  ",";
            testMan += customers[i].GetUserId();
        }
        
        tests.PopulateManifest();
        
        
        Assert.AreEqual(tests.GetFlightManifest(), testMan);

    }
}