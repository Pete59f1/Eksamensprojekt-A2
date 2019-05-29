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
        
        //PlantType Test
        [TestMethod]
        public void PlantType_Constructor()
        {
            PlantType p = new PlantType(1, "Rose", "14", "25", "30", "20");
        }
        [TestMethod]
        public void PlantType_Can_Get_Properties()
        {
            PlantType p = new PlantType(1, "Rose", "14", "25", "30", "20");

            Assert.AreEqual(1, p.PlantId);
            Assert.AreEqual("Rose", p.Type);
            Assert.AreEqual("14", p.PhaseOne);
            Assert.AreEqual("25", p.PhaseTwo);
            Assert.AreEqual("30", p.PhaseThree);
            Assert.AreEqual("20", p.PhaseFour);
        }
        //PictureStatus Test
        [TestMethod]
        public void PictureStatus_Does_Have_All_Statuses()
        {
            PictureStatus pictureStatus = PictureStatus.Dead;
            pictureStatus = PictureStatus.ExceptionalGrowth;
            pictureStatus = PictureStatus.NoGrowth;
            pictureStatus = PictureStatus.NormalGrowth;
            pictureStatus = PictureStatus.SomeGrowth;

            Assert.IsNotNull(pictureStatus);
        }
        //Picture Test
        [TestMethod]
        public void Picture_Constructor()
        {
            Picture p = new Picture(1, DateTime.Now, "God", PictureStatus.Dead, @"c:\12-12-2019 00:11:12.png", 1);
        }
        [TestMethod]
        public void Picture_Can_Get_Properties()
        {
            Picture p = new Picture(1, new DateTime(2019,01,01,01,01,01), "God", PictureStatus.Dead, @"c:\12-12-2019 00:11:12.png", 1);

            Assert.AreEqual(1, p.PictureId);
            Assert.AreEqual(new DateTime(2019, 01, 01, 01, 01, 01), p.Name);
            Assert.AreEqual("God", p.Comment);
            Assert.AreEqual(PictureStatus.Dead, p.Status);
            Assert.AreEqual(@"c:\12-12-2019 00:11:12.png", p.PictureLink);
            Assert.AreEqual(1, p.TrayNumber);
        }
        [TestMethod]
        public void Picture_Convert_StringStatus_To_Enum_PictureStatus()
        {
            string dead = "Dead";
            PictureStatus deadPictureStatus = Picture.ConvertStringStatusToEnumStatus(dead);

            Assert.AreEqual(PictureStatus.Dead, deadPictureStatus);
        }
    }
}
