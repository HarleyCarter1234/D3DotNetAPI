using System;
using System.Collections.Generic;
using System.Linq;
using D3DotNetAPI;
using D3DotNetAPI.Models;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            D3Explorer explorer = new D3Explorer(Region.EU);

            //Career data for Battletag Gaidin#2380
            Career myCareer = explorer.GetCareer("Gaidin", 2380);

            Console.WriteLine("CAREER DATA SAMPLE");
            Console.WriteLine();

            Console.WriteLine("Has killed {0} monstters, with {1} elites.", myCareer.Kills.Monsters, myCareer.Kills.Elites);
            foreach (CareerHero h in myCareer.Heroes)
            {
                Console.WriteLine("{0} is a {1} of level {2}", h.Name, h.Class, h.Level);
                Console.WriteLine();
            }

            Console.WriteLine("Season 0 Paragon Level : {0}", myCareer.SeasonalProfiles.Season0.ParagonLevel);
            Console.WriteLine("Season 1 Paragon Level : {0}", myCareer.SeasonalProfiles.Season1.ParagonLevel);
            Console.WriteLine("Season 2 Paragon Level : {0}", myCareer.SeasonalProfiles.Season2.ParagonLevel);
            Console.WriteLine("Season 3 Paragon Level : {0}", myCareer.SeasonalProfiles.Season3.ParagonLevel);
            Console.WriteLine("Season 4 Paragon Level : {0}", myCareer.SeasonalProfiles.Season4.ParagonLevel);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HERO DATA SAMPLE");
            Console.WriteLine();

            foreach (CareerHero h in myCareer.Heroes)
            {
                Hero hero = explorer.GetHero("Gaidin", 2380, h.Id);
                Console.WriteLine("{0} has {1} elite kills", hero.Name, hero.Kills.Elites);
                Console.WriteLine("     Is act 5 completed? : {0}", hero.Progression.Act5.Completed);
                Console.WriteLine("     Damage : {0}", hero.Stats.Damage);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FOLLOWER DATA SAMPLE");
            Console.WriteLine();

            Follower follower = explorer.GetFollower(FollowerType.scoundrel);
            Console.WriteLine("Scoundrel skills:");
            foreach (SkillActiveHeader s in follower.Skills.ActiveSkills)
            {
                Console.WriteLine("     {0} : {1}",s.Name, s.SimpleDescription);
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ITEM DATA SAMPLE");
            Console.WriteLine();

            Item item = explorer.GetItem("CPjT4eQLEgcIBBX1otksHZuwzNAdPoRWVB2xIBV7HTeqe1AdSmNPMDAJOLwDQABQEmC8Aw");
            Console.WriteLine("{0} does {1} DPS", item.Name, item.DPS.Max);
            Console.WriteLine();

            var gaidin = explorer.GetHero("Gaidin", 2380, 709695);
            var i = explorer.GetItem(gaidin.Items.Head.IdForAPI);
            Console.WriteLine("{0} is wearing {1} on his head which has {2} armor",gaidin.Name,i.Name,i.Armor.Max);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
