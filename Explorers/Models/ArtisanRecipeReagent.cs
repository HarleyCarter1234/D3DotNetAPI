using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ArtisanRecipeReagent
    {
        [DataMember(Name = "quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "item")]
        public ItemHeader Item { get; set; }
    }
}
