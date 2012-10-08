using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class ItemAttributesRaw
    {
        [DataMember(Name = "Attacks_Per_Second_Item")]
        public ItemMinMax AttacksPerSecond { get; set; }

        [DataMember(Name = "Damage_Weapon_Min#Physical")]
        public ItemMinMax DamageMinPhysical { get; set; }

        [DataMember(Name = "Damage_Weapon_Delta#Physical")]
        public ItemMinMax DamageDeltaPhysical { get; set; }

        [DataMember(Name = "Strength_Item")]
        public ItemMinMax Strength { get; set; }

        [DataMember(Name = "Durability_Cur")]
        public ItemMinMax DurabilityCurrent { get; set; }

        [DataMember(Name = "Durability_Max")]
        public ItemMinMax DurabilityMax { get; set; }

        [DataMember(Name = "Steal_Health_Percent")]
        public ItemMinMax StealHealthPercent { get; set; }

        [DataMember(Name = "Vitality_Item")]
        public ItemMinMax Vitality { get; set; }
    }
}
