using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedCheetah.UserInterface.Services;

namespace RedCheetah.UnitTest
{
    [TestClass]
    public class TestADSvc
    {
        [TestMethod]
        public void Authenticate()
        {
            ActiveDirectorySvc ad = new ActiveDirectorySvc();

            var resp = ad.IsAuthenticated("LDAP://swiftng.net","solatunji","Administrator*01");

            Assert.IsTrue(resp);
        }
    }
}
