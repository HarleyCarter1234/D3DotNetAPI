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
        //need to add FallenHeroes data still

        [DataMember(Name = "lastHeroPlayed")]
        public long LastHeroPlayed { get; set; }

        [DataMember(Name = "lastUpdated")]
        public long LastUpdated { get; set; }

        [DataMember(Name = "heroes")]
        public IEnumerable<CareerHero> Heroes { get; set; }

        [DataMember(Name = "artisans")]
        public IEnumerable<CareerArtisan> Artisans { get; set; }

        [DataMember(Name = "hardcoreArtisans")]
        public IEnumerable<CareerArtisan> HardcoreArtisans { get; set; }

        [DataMember(Name = "kills")]
        public CareerKills Kills { get; set; }

        [DataMember(Name = "battleTag")]
        public string BattleTag { get; set; }

        [DataMember(Name = "timePlayed")]
        public CareerTimePlayed TimePlayed { get; set; }

        [DataMember(Name = "progression")]
        public CareerProgress Progression { get; set; }

        [DataMember(Name = "hardcoreProgression")]
        public CareerProgress HardcoreProgression { get; set; }
    }
}
