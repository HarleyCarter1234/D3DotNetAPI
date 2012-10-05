using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerProgressDifficulty
    {
        [DataMember(Name = "act1")]
        public CareerProgressAct Act1 { get; set; }

        [DataMember(Name = "act2")]
        public CareerProgressAct Act2 { get; set; }

        [DataMember(Name = "act3")]
        public CareerProgressAct Act3 { get; set; }

        [DataMember(Name = "act4")]
        public CareerProgressAct Act4 { get; set; }
    }
}
