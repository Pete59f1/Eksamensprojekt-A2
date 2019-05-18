using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruppeA2.Domain;

namespace Test
{
    /// <summary>
    /// Summary description for DomainTest
    /// </summary>
    [TestClass]
    public class DomainTest
    {
        static DateTime date;
        Picture pictureTest;

        [TestInitialize]
        public void DomainTestInitialize()
        {
            date = new DateTime(2019 - 01 - 01, 11, 32);
            pictureTest = new Picture(1, date, "HEJ", "1", "C:\\Test");
        }

        
        //Picture Test
        [TestMethod]
        public void TestPictureFindStatus()
        {
            PictureStatus stat = pictureTest.FindStatus("2");
            Assert.AreEqual(PictureStatus.NormalGrowth, stat);
        }
    }
}
