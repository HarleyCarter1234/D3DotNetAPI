using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ArtisanTrainingTier
    {
        [DataMember(Name = "tier")]
        public int Tier { get; set; }

        [DataMember(Name = "levels")]
        public IEnumerable<ArtisanTrainingLevel> Levels { get; set; }
    }
}
