using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class Career
    {
        [DataMember(Name = "battleTag")]
        public string BattleTag { get; set; }

        [DataMember(Name = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [DataMember(Name = "paragonLevelHardcore")]
        public int ParagonLevelHardcore { get; set; }

        [DataMember(Name = "paragonLevelSeason")]
        public int ParagonLevelSeason { get; set; }

        [DataMember(Name = "paragonLevelSeasonHardcore")]
        public int ParagonLevelSeasonHardcore { get; set; }

        [DataMember(Name = "guildName")]
        public string GuildName { get; set; }

        [DataMember(Name = "heroes")]
        public IEnumerable<CareerHero> Heroes { get; set; }

        [DataMember(Name = "lastHeroPlayed")]
        public long LastHeroPlayed { get; set; }

        [DataMember(Name = "lastUpdated")]
        public long LastUpdated { get; set; }

        [DataMember(Name = "kills")]
        public CareerKills Kills { get; set; }

        [DataMember(Name = "highestHardcoreLevel")]
        public int HighestHardcoreLevel { get; set; }

        [DataMember(Name = "timePlayed")]
        public CareerTimePlayed TimePlayed { get; set; }

        [DataMember(Name = "progression")]
        public CareerProgress Progression { get; set; }

        [DataMember(Name = "fallenHeroes")]
        public IEnumerable<CareerFallenHero> FallenHeroes { get; set; }

        [DataMember(Name = "blacksmith")]
        public CareerArtisan Blacksmith { get; set; }

        [DataMember(Name = "jeweler")]
        public CareerArtisan Jeweler { get; set; }

        [DataMember(Name = "mystic")]
        public CareerArtisan Mystic { get; set; }

        [DataMember(Name = "blacksmithHardcore")]
        public CareerArtisan BlacksmithHardcore { get; set; }

        [DataMember(Name = "jewelerHardcore")]
        public CareerArtisan JewelerHardcore { get; set; }

        [DataMember(Name = "mysticHardcore")]
        public CareerArtisan MysticHarcore { get; set; }

        [DataMember(Name = "blacksmithSeason")]
        public CareerArtisan BlacksmithSeason { get; set; }

        [DataMember(Name = "jewelerSeason")]
        public CareerArtisan JewelerSeason { get; set; }

        [DataMember(Name = "mysticSeason")]
        public CareerArtisan MysticSeasone { get; set; }

        [DataMember(Name = "blacksmithSeasonHardcore")]
        public CareerArtisan BlacksmithSeasonHardcore { get; set; }

        [DataMember(Name = "jewelerSeasonHardcore")]
        public CareerArtisan JewelerSeasonHardcore { get; set; }

        [DataMember(Name = "mysticSeasonHardcore")]
        public CareerArtisan MysticSeasonHarcore { get; set; }

        [DataMember(Name = "seasonalProfiles")]
        public CareerSeasonProfiles SeasonalProfiles { get; set; }

    }
}
