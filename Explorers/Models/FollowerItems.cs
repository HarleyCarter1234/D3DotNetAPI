using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class FollowerItems
    {
        [DataMember(Name = "mainHand")]
        public ItemHeader MainHand { get; set; }

        [DataMember(Name = "offHand")]
        public ItemHeader OffHand { get; set; }

        [DataMember(Name = "rightFinger")]
        public ItemHeader RightFinger { get; set; }

        [DataMember(Name = "leftFinger")]
        public ItemHeader LeftFinger { get; set; }

        [DataMember(Name = "neck")]
        public ItemHeader Neck { get; set; }

        [DataMember(Name = "special")]
        public ItemHeader Special { get; set; }
    }
}
