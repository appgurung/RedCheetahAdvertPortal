using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedCheetah.UserInterface.Services;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;

namespace RedCheetah.UnitTest
{
    [TestClass]
    public class TestSectorSvc
    {
        RedCheetahStaging _db = new RedCheetahStaging();

        [TestMethod]
        public void AddSector()
        {
            bool resp = new SectorSvc(_db).AddSector("Sector 1");

            Assert.IsTrue(resp);

        }

        [TestMethod]
        public void UpdateSector()
        {
            bool resp = new SectorSvc(_db).UpdateSector(1, "Sector 2");

            Assert.IsTrue(resp);
        }

        [TestMethod]
        public void DeleteSector()
        {
            bool resp = new SectorSvc(_db).DeleteSector(1);

            Assert.IsTrue(resp);
        }
    }
}
