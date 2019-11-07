using NUnit.Framework;
using SeleniumCore.PageObjects;
using SeleniumCore.Tests;

namespace Tests
{
    [TestFixture]
    [Parallelizable]
    public class HomePageSauceLabsTest : BaseTest
    {
        SaucelabsPage saucelabsPage;


        [SetUp]
        public new void SetUp(){
            
            saucelabsPage = new SaucelabsPage(Driver);
        }

        [Test]
        public void ShouldBeAbleToLogin()
        {
            saucelabsPage.With("standard_user", "secret_sauce");
            Assert.That(Driver.Url.Contains("inventory.html"));
        }

    }
}
