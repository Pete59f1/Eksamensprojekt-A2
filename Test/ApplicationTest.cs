using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruppeA2.Application;
using GruppeA2.Domain;

namespace Test
{
    /// <summary>
    /// Summary description for ApplicationTest
    /// </summary>
    [TestClass]
    public class ApplicationTest
    {
        //PlantTypeRepo Test
        [TestMethod]
        public void PlantTypeRepo_Constructor()
        {
            PlantTypeRepo p = new PlantTypeRepo();
        }
        [TestMethod]
        public void PlantTypeRepo_Can_Add_Item()
        {
            PlantTypeRepo p = new PlantTypeRepo();
            p.AddItem(new PlantType(1, "Rose", "15", "20", "25", "20"));
        }
        [TestMethod]
        public void PlantTypeRepo_Can_Get_Item()
        {
            PlantTypeRepo p = new PlantTypeRepo();
            p.AddItem(new PlantType(1, "Rose", "15", "20", "25", "20"));

            Assert.AreEqual(new PlantType(1, "Rose", "15", "20", "25", "20"), p.RepoCollection[0]);
            Assert.AreEqual(new PlantType(1, "Rose", "15", "20", "25", "20"), p.GetItem(0));
        }
        [TestMethod]
        public void PlantTypeRepo_Can_Get_Properties_From_Item_Using_Methods()
        {
            PlantTypeRepo p = new PlantTypeRepo();
            p.AddItem(new PlantType(1, "Rose", "15", "20", "25", "20"));

            Assert.AreEqual(1, p.GetPlantId(0));
            Assert.AreEqual("Rose", p.GetPlantType(0));
            Assert.AreEqual("15", p.GetPlantPhaseOne(0));
            Assert.AreEqual("20", p.GetPlantPhaseTwo(0));
            Assert.AreEqual("25", p.GetPlantPhaseThree(0));
            Assert.AreEqual("20", p.GetPlantPhaseFour(0));
        }
        [TestMethod]
        public void PlantTypeRepo_Can_Remove_Item_At_Specific_Index()
        {
            PlantTypeRepo p = new PlantTypeRepo();
            p.AddItem(new PlantType(1, "Rose", "15", "20", "25", "20"));

            Assert.IsNotNull(p.RepoCollection[0]);
            p.RemoveItem(0);
            Assert.IsFalse(p.RepoCollection.Contains(new PlantType(1, "Rose", "15", "20", "25", "20")));
        }
        //NewPicturesRepo Test
        [TestMethod]
        public void NewPicturesRepo_Constructor()
        {
            NewPicturesRepo newPictures = new NewPicturesRepo();

        }
        [TestMethod]
        public void NewPicturesRepo_Can_Add_Item()
        {
            NewPicturesRepo newPictures = new NewPicturesRepo();
            newPictures.AddItem(new Picture(1, new DateTime(2019, 01, 01), "God", PictureStatus.SomeGrowth, @"c:\2019-01-01 24:24:24.png", 1));

        }
        [TestMethod]
        public void NewPicturesRepo_Can_Get_Item()
        {
            Assert.Fail();
        }
    }
}
