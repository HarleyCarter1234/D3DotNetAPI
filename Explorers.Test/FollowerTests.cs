using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D3DotNetAPI.Models;

namespace D3DotNetAPI.Explorers.Test
{
    [TestClass]
    public class FollowerTests
    {
        private static D3Explorer explorer;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            explorer = new D3Explorer(Region.EU);
        }

        [TestMethod]
        public void Get_Follower_Templar()
        {
            var follower = explorer.GetFollower(FollowerType.templar);

            Assert.AreEqual("Templar", follower.Name);
            Assert.IsTrue(follower.Skills.ActiveSkills.Count() > 1);
        }

        [TestMethod]
        public void Get_Follower_Scoundrel()
        {
            var follower = explorer.GetFollower(FollowerType.scoundrel);

            Assert.AreEqual("Scoundrel", follower.Name);
            Assert.IsTrue(follower.Skills.ActiveSkills.Count() > 1);
        }

        [TestMethod]
        public void Get_Follower_Enchantress()
        {
            var follower = explorer.GetFollower(FollowerType.enchantress);

            Assert.AreEqual("Enchantress", follower.Name);
            Assert.IsTrue(follower.Skills.ActiveSkills.Count() > 1);
        }
    }
}
