using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class SkillActiveRune
    {
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }               

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "simpleDescription")]
        public string SimpleDescription { get; set; }

        [DataMember(Name = "tooltipParams")]
        public string TooltipParams { get; set; }

        [DataMember(Name = "orderIndex")]
        public string OrderIndex { get; set; }
    }
}
