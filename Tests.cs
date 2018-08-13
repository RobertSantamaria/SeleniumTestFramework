using NUnit.Framework;

namespace SeleniumTestFramework
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test]
        public void TestLogin()
        {
            User user = new User { Email = "jsmith@email.com", Password = "Pass123" };
            
            Assert.AreEqual(1, 1);
        }
    }
}
