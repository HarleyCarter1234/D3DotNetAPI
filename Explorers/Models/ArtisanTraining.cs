using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ArtisanTraining
    {
        [DataMember(Name = "tiers")]
        public IEnumerable<ArtisanTrainingTier> Tiers { get; set; }
    }
}
