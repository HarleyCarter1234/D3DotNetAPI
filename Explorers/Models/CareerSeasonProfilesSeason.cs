using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerSeasonProfilesSeason
    {
        [DataMember(Name = "seasonId")]
        public int SeasonId { get; set; }

        [DataMember(Name = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [DataMember(Name = "paragonLevelHardcore")]
        public int ParagonLevelHardcore { get; set; }

        [DataMember(Name = "kills")]
        public CareerKills Kills { get; set; }

        [DataMember(Name = "timePlayed")]
        public CareerTimePlayed TimePlayed { get; set; }

        [DataMember(Name = "highestHardcoreLevel")]
        public int HighestHardcoreLevel { get; set; }

        [DataMember(Name = "progression")]
        public CareerProgress Progression { get; set; }

    }
}
