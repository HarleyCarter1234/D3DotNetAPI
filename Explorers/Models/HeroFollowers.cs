using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroFollowers
    {
        [DataMember(Name = "templar")]
        public HeroFollower Templar { get; set; }

        [DataMember(Name = "enchantress")]
        public HeroFollower Enchantress { get; set; }

        [DataMember(Name = "scoundrel")]
        public HeroFollower Scoundrel { get; set; }
    }
}
