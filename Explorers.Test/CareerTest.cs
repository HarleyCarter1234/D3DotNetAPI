using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D3DotNetAPI.Models;

namespace D3DotNetAPI.Explorers.Test
{
    [TestClass]
    public class CareerTest
    {
        private static D3Explorer explorer;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            explorer = new D3Explorer(Region.EU);
        }

        [TestMethod]
        public void Get_Career_Gaidin_2380()
        {
            explorer.Region = Region.EU;
            var gaidin = explorer.GetCareer("Gaidin", 2380);

            Assert.IsTrue(gaidin.Heroes.Count() > 1);
            Assert.IsTrue(gaidin.Kills.Monsters > 0);
            Assert.IsTrue(gaidin.TimePlayed.WitchDoctor > 0);
            Assert.IsTrue(gaidin.Progression.Inferno.Act3.Completed = true);
            Assert.IsTrue(gaidin.Artisans.Count() > 1);
            Assert.IsTrue(gaidin.HardcoreArtisans.Count() > 1);
        }

        //[TestMethod]
        //public void Get_Career_Straton_1()
        //{
        //    explorer.Region = Region.US;
        //    var straton = explorer.GetCareer("Straton", 1);

        //    Assert.IsTrue(straton.Heroes.Count() > 1);
        //    Assert.IsTrue(straton.Kills.Monsters > 0);
        //    Assert.IsTrue(straton.TimePlayed.WitchDoctor > 0);
        //    Assert.IsTrue(straton.Progression.Inferno.Act3.Completed = true);
        //    Assert.IsTrue(straton.Artisans.Count() > 1);
        //    Assert.IsTrue(straton.HardcoreArtisans.Count() > 1);
        //    Assert.IsTrue(straton.FallenHeroes.Count() > 0);
        //}
    }
}
