using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class Hero
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "class")]
        public string Class { get; set; }

        [DataMember(Name = "gender")]
        public int Gender { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "kills")]
        public CareerKills Kills { get; set; }

        [DataMember(Name = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [DataMember(Name = "hardcore")]
        public bool Hardcore { get; set; }

        [DataMember(Name = "seasonal")]
        public bool Seasonal { get; set; }

        [DataMember(Name = "seasonCreated")]
        public int SeasonCreated { get; set; }

        [DataMember(Name = "skills")]
        public HeroSkills Skills { get; set; }

        [DataMember(Name = "items")]
        public HeroItems Items { get; set; }

        [DataMember(Name = "followers")]
        public HeroFollowers Followers { get; set; }

        [DataMember(Name = "legendaryPowers")]
        public IEnumerable<HeroLegendaryPower> LegendaryPowers { get; set; }

        [DataMember(Name = "stats")]
        public HeroStats Stats { get; set; }

        [DataMember(Name = "progression")]
        public HeroProgression Progression { get; set; }

        [DataMember(Name = "dead")]
        public bool Dead { get; set; }

        [DataMember(Name = "last-updated")]
        public long LastUpdated { get; set; }

    }
}
