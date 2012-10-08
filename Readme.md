D3DotNetAPI
=========
D3DotNetAPI is a C# .Net library for the Diablo 3 Community Platform API

This library is based on the great WoWDotNetAPI by Brian Ramos which can be found on GitHub at http://github.com/briandek/WowDotNetAPI

Sample:
=========

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
					Console.WriteLine("     Is nightmare level completed? : {0}", hero.Progress.Nightmare.Act4.Completed);
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



Contributing
============
 
Please feel free to jump in and contribute to the project.  
Just fork the project, commit your changes (preferably to a new branch), and then send me a pull request via GitHub. 
Please add tests for your feature or fix.
 
License
=======
 
D3DotNetAPI is released under the MIT license.
 
    Copyright (c) 2012 Harley Carter
 
    Permission is hereby granted, free of charge, to any person
    obtaining a copy of this software and associated documentation
    files (the "Software"), to deal in the Software without
    restriction, including without limitation the rights to use,
    copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the
    Software is furnished to do so, subject to the following
    conditions:
 
    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.
 
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
    OTHER DEALINGS IN THE SOFTWARE.