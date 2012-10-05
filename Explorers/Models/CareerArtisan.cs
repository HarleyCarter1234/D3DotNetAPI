using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerArtisan
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "stepCurrent")]
        public int StepCurrent { get; set; }

        [DataMember(Name = "stepMax")]
        public int StepMax { get; set; }
    }
}
