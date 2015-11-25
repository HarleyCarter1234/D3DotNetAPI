using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerHero
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

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
        public bool Harcore { get; set; }

        [DataMember(Name = "seasonal")]
        public bool Seasonal { get; set; }

        [DataMember(Name = "lastUpdated")]
        public long LastUpdated { get; set; }

        [DataMember(Name = "dead")]
        public bool Dead { get; set; }
    }
}
