﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerProgress
    {
        [DataMember(Name = "act1")]
        public bool Act1 { get; set; }

        [DataMember(Name = "act2")]
        public bool Act2 { get; set; }

        [DataMember(Name = "act3")]
        public bool Act3 { get; set; }

        [DataMember(Name = "act4")]
        public bool Act4 { get; set; }

        [DataMember(Name = "act5")]
        public bool Act5 { get; set; }
    }
}
