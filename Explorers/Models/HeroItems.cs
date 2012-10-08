using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroItems
    {
        [DataMember(Name = "head")]
        public ItemHeader Head { get; set; }

        [DataMember(Name = "torso")]
        public ItemHeader Torso { get; set; }

        [DataMember(Name = "feet")]
        public ItemHeader Feet { get; set; }

        [DataMember(Name = "hands")]
        public ItemHeader Hands { get; set; }

        [DataMember(Name = "shoulders")]
        public ItemHeader Shoulders { get; set; }

        [DataMember(Name = "legs")]
        public ItemHeader Legs { get; set; }

        [DataMember(Name = "bracers")]
        public ItemHeader Bracers { get; set; }

        [DataMember(Name = "mainHand")]
        public ItemHeader MainHand { get; set; }

        [DataMember(Name = "offHand")]
        public ItemHeader OffHand { get; set; }

        [DataMember(Name = "waist")]
        public ItemHeader Waist { get; set; }

        [DataMember(Name = "rightFinger")]
        public ItemHeader RightFinger { get; set; }

        [DataMember(Name = "leftFinger")]
        public ItemHeader LeftFinger { get; set; }

        [DataMember(Name = "neck")]
        public ItemHeader Neck { get; set; }
    }
}
