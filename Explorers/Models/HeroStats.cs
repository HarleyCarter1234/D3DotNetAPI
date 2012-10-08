using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class HeroStats
    {
        [DataMember(Name = "damageIncrease")]
        public double DamageIncrease { get; set; }

        [DataMember(Name = "damageReduction")]
        public double DamageReduction { get; set; }

        [DataMember(Name = "critChance")]
        public double critChance { get; set; }

        [DataMember(Name = "life")]
        public int Life { get; set; }

        [DataMember(Name = "strength")]
        public int Strength { get; set; }

        [DataMember(Name = "dexterity")]
        public int Dexterity { get; set; }

        [DataMember(Name = "intelligence")]
        public int Intelligence { get; set; }

        [DataMember(Name = "vitality")]
        public int Vitality { get; set; }

        [DataMember(Name = "armor")]
        public int Armor { get; set; }

        [DataMember(Name = "coldResist")]
        public double ColdResist { get; set; }

        [DataMember(Name = "fireResist")]
        public double FireResist { get; set; }

        [DataMember(Name = "lightningResist")]
        public double LightningResist { get; set; }

        [DataMember(Name = "poisonResist")]
        public double PoisonResist { get; set; }

        [DataMember(Name = "arcaneResist")]
        public double ArcaneResist { get; set; }

        [DataMember(Name = "damage")]
        public double Damage { get; set; }
    }
}
