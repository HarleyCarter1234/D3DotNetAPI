using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerFallenHeroDeath
    {
        [DataMember(Name = "killer")]
        public long Killer { get; set; }

        [DataMember(Name = "location")]
        public long Location { get; set; }

        [DataMember(Name = "time")]
        public long Time { get; set; }
    }
}
