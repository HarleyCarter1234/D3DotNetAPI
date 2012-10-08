using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ArtisanTrainingLevel
    {
        [DataMember(Name = "tier")]
        public int Tier { get; set; }

        [DataMember(Name = "tierLevel")]
        public int TireLevel { get; set; }

        [DataMember(Name = "percent")]
        public double Percent { get; set; }

        [DataMember(Name = "trainedRecipes")]
        public IEnumerable<ArtisanTrainingRecipe> TrainedRecipes { get; set; }

        [DataMember(Name = "taughtRecipes")]
        public IEnumerable<ArtisanTrainingRecipe> TaughtRecipes { get; set; }

        [DataMember(Name = "upgradeItems")]
        public IEnumerable<ArtisanRecipeReagent> UpgradeItems { get; set; }

        [DataMember(Name = "upgradeCost")]
        public int UpgradeCost { get; set; }
    }
}
