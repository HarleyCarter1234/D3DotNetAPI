using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class SkillActive
    {
        [DataMember(Name = "skill")]
        public SkillActiveHeader Skill { get; set; }

        [DataMember(Name = "rune")]
        public SkillActiveRune Rune { get; set; }
    }
}
