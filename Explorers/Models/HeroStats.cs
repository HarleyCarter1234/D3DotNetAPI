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
        [DataMember(Name = "life")]
        public int Life { get; set; }

        [DataMember(Name = "damage")]
        public double Damage { get; set; }

        [DataMember(Name = "toughness")]
        public double Toughness { get; set; }

        [DataMember(Name = "healing")]
        public double Healing { get; set; }

        [DataMember(Name = "attackSpeed")]
        public double AttackSpeed { get; set; }

        [DataMember(Name = "armor")]
        public int Armor { get; set; }

        [DataMember(Name = "strength")]
        public int Strength { get; set; }

        [DataMember(Name = "dexterity")]
        public int Dexterity { get; set; }

        [DataMember(Name = "intelligence")]
        public int Intelligence { get; set; }

        [DataMember(Name = "vitality")]
        public int Vitality { get; set; }

        [DataMember(Name = "physicalResist")]
        public double PhysicalResist { get; set; }

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

        [DataMember(Name = "critDamage")]
        public double CritDamage { get; set; }

        [DataMember(Name = "blockChance")]
        public double Blockchance { get; set; }

        [DataMember(Name = "blockAmountMin")]
        public int BlockAmountMin { get; set; }

        [DataMember(Name = "blockAmountMax")]
        public int BlockAmountMax { get; set; }

        [DataMember(Name = "damageIncrease")]
        public double DamageIncrease { get; set; }

        [DataMember(Name = "critChance")]
        public double CritChance { get; set; }

        [DataMember(Name = "damageReduction")]
        public double DamageReduction { get; set; }

        [DataMember(Name = "thorns")]
        public double Thorns { get; set; }

        [DataMember(Name = "lifeSteal")]
        public double LifeSteal { get; set; }

        [DataMember(Name = "lifePerKill")]
        public double LifePerKill { get; set; }

        [DataMember(Name = "goldFind")]
        public double GoldFind { get; set; }

        [DataMember(Name = "magicFind")]
        public double MagicFind { get; set; }

        [DataMember(Name = "lifeOnHit")]
        public double LifeOnHit { get; set; }

        [DataMember(Name = "primaryResource")]
        public int PrimaryResource { get; set; }

        [DataMember(Name = "secondaryResource")]
        public int SecondaryResource { get; set; }
    }
}
