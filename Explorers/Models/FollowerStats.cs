using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class FollowerStats
    {
        [DataMember(Name = "goldFind")]
        public double GoldFind { get; set; }

        [DataMember(Name = "magicFind")]
        public double MagicFind { get; set; }

        [DataMember(Name = "experienceBonus")]
        public double ExperienceBonus { get; set; }
    }
}
