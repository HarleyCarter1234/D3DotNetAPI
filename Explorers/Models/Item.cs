using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "displayColor")]
        public string DisplayColor { get; set; }

        [DataMember(Name = "tooltipParams")]
        public string TooltipParams { get; set; }

        [DataMember(Name = "requiredLevel")]
        public int RequiredLevel { get; set; }

        [DataMember(Name = "itemLevel")]
        public int ItemLevel { get; set; }

        [DataMember(Name = "flavorText")]
        public string FlavorText { get; set; }

        [DataMember(Name = "bonusAffixes")]
        public int BonusAffixes { get; set; }

        [DataMember(Name = "dps")]
        public ItemMinMax DPS { get; set; }

        [DataMember(Name = "attacksPerSecond")]
        public ItemMinMax AttacksPerSecond { get; set; }

        [DataMember(Name = "minDamage")]
        public ItemMinMax MinDamage { get; set; }

        [DataMember(Name = "maxDamage")]
        public ItemMinMax MaxDamage { get; set; }

        [DataMember(Name = "attributes")]
        public IEnumerable<string> Attributes { get; set; }

        [DataMember(Name = "attributesRaw")]
        public ItemAttributesRaw AttributesRaw { get; set; }

        [DataMember(Name = "armor")]
        public ItemMinMax Armor { get; set; }

        [DataMember(Name = "salvage")]
        public IEnumerable<ItemSalvagePossibility> Salvage { get; set; }

        public string IdForAPI
        {
            get
            {
                return TooltipParams.Replace("item/","");
            }
        }
    }
}
