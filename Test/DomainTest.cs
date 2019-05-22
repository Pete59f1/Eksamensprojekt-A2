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
