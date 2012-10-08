using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D3DotNetAPI.Models;

namespace D3DotNetAPI.Explorers.Test
{
    [TestClass]
    public class ArtisanTests
    {
        private static D3Explorer explorer;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            explorer = new D3Explorer(Region.EU);
        }

        [TestMethod]
        public void Get_Artisan_Blacksmith()
        {
            var artisan = explorer.GetArtisan(ArtisanType.blacksmith);

            Assert.AreEqual("Blacksmith", artisan.Name);
            Assert.IsTrue(artisan.Training.Tiers.Count() > 1);
        }

        [TestMethod]
        public void Get_Artisan_Jeweler()
        {
            var artisan = explorer.GetArtisan(ArtisanType.jeweler);

            Assert.AreEqual("Jeweler", artisan.Name);
            Assert.IsTrue(artisan.Training.Tiers.Count() > 1);
        }
    }
}
