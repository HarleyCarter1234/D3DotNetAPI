using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ArtisanTrainingRecipe
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "cost")]
        public int Cost { get; set; }

        [DataMember(Name = "reagents")]
        public IEnumerable<ArtisanRecipeReagent> Reagents { get; set; }

        [DataMember(Name = "itemProduced")]
        public IEnumerable<ItemHeader> ItemProduced { get; set; }
    }
}
