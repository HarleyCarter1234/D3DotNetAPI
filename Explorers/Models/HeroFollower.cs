using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroFollower
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "skills")]
        public IEnumerable<SkillActive> Skills { get; set; }

        [DataMember(Name = "items")]
        public FollowerItems Items { get; set; }

        [DataMember(Name = "stats")]
        public FollowerStats Stats { get; set; }
    }
}
