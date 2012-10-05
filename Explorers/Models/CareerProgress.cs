using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerProgress
    {
        [DataMember(Name = "normal")]
        public CareerProgressDifficulty Normal { get; set; }

        [DataMember(Name = "nightmare")]
        public CareerProgressDifficulty Nightmare { get; set; }

        [DataMember(Name = "hell")]
        public CareerProgressDifficulty Hell { get; set; }

        [DataMember(Name = "inferno")]
        public CareerProgressDifficulty Inferno { get; set; }
    }
}
