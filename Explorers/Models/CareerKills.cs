using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerKills
    {
        [DataMember(Name = "monsters")]
        public long Monsters { get; set; }

        [DataMember(Name = "elites")]
        public long Elites { get; set; }

        [DataMember(Name = "hardcoreMonsters")]
        public long HardcoreMonsters { get; set; }
    }
}
