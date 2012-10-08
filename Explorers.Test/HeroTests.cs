using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D3DotNetAPI.Models;

namespace D3DotNetAPI.Explorers.Test
{
    [TestClass]
    public class HeroTests
    {
        private static D3Explorer explorer;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            explorer = new D3Explorer(Region.EU);
        }

        [TestMethod]
        public void Get_Hero_Gaidin()
        {
            var hero = explorer.GetHero("Gaidin", 2380, 709695);

            Assert.AreEqual("Gaidin", hero.Name);
            Assert.IsTrue(hero.Skills.ActiveSkills.Count() > 1);            
        }
    }
}
