using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroSkills
    {
        [DataMember(Name = "active")]
        public IEnumerable<SkillActive> ActiveSkills { get; set; }

        [DataMember(Name = "passive")]
        public IEnumerable<SkillPassive> PassiveSkills { get; set; }
    }
}
