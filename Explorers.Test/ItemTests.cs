using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D3DotNetAPI.Models;

namespace D3DotNetAPI.Explorers.Test
{
    [TestClass]
    public class ItemTests
    {
        private static D3Explorer explorer;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            explorer = new D3Explorer(Region.EU);
        }

        [TestMethod]
        public void Get_Sample_Item_COGHsoAIEgcIBBXIGEoRHYQRdRUdnWyzFB2qXu51MA04kwNAAFAKYJMD()
        {
            var sampleItem = explorer.GetItem("COGHsoAIEgcIBBXIGEoRHYQRdRUdnWyzFB2qXu51MA04kwNAAFAKYJMD");

            Assert.AreEqual("Exsanguinating Chopsword of Assault", sampleItem.Name);
            Assert.IsTrue(sampleItem.DPS.Max > 0);
            Assert.IsTrue(sampleItem.AttributesRaw.AttacksPerSecond.Max > 0);
            Assert.IsTrue(sampleItem.Salvage.Count() > 1);            
        }

        [TestMethod]
        public void Get_Sample_Item_CPvK9pADEgcIBBU69U5dHTIL5KIdAnSATAJOPUDQABIFVAIYPUD()
        {
            var sampleItem = explorer.GetItem("CPvK9pADEgcIBBU69U5dHTIL5KIdAn-SATAJOPUDQABIFVAIYPUD");

            Assert.AreEqual("Wild Casque of Invasion", sampleItem.Name);
            Assert.IsTrue(sampleItem.Armor.Max > 0);            
        }

        [TestMethod]
        public void Get_Sample_Item_CPjT4eQLEgcIBBX1otksHZuwzNAdPoRWVB2xIBV7HTeqe1AdSmNPMDAJOLwDQABQEmC8Aw()
        {
            var sampleItem = explorer.GetItem("CPjT4eQLEgcIBBX1otksHZuwzNAdPoRWVB2xIBV7HTeqe1AdSmNPMDAJOLwDQABQEmC8Aw");

            Assert.AreEqual("Skywarden", sampleItem.Name);
            Assert.AreEqual("Favored weapon of the angelic Host.", sampleItem.FlavorText);            
        }

    }
}
