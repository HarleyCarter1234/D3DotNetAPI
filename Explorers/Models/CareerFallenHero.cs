using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerFallenHero
    {
        [DataMember(Name = "stats")]
        public HeroStats Stats { get; set; }

        [DataMember(Name = "kills")]
        public CareerKills Kills { get; set; }

        [DataMember(Name = "items")]
        public HeroItems Items { get; set; }

        [DataMember(Name = "death")]
        public CareerFallenHeroDeath Death { get; set; }

        [DataMember(Name = "heroId")]
        public string HeroId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "gender")]
        public int Gender { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "hardcore")]
        public bool Hardcore { get; set; }
    }
}
