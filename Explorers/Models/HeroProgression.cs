using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroProgression
    {
        [DataMember(Name = "act1")]
        public HeroProgressAct Act1 { get; set; }

        [DataMember(Name = "act2")]
        public HeroProgressAct Act2 { get; set; }

        [DataMember(Name = "act3")]
        public HeroProgressAct Act3 { get; set; }

        [DataMember(Name = "act4")]
        public HeroProgressAct Act4 { get; set; }

        [DataMember(Name = "act5")]
        public HeroProgressAct Act5 { get; set; }
    }
}
