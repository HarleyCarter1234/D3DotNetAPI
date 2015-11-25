using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerTimePlayed
    {
        [DataMember(Name = "barbarian")]
        public double Barbarian { get; set; }

        [DataMember(Name = "demon-hunter")]
        public double DemonHunter { get; set; }

        [DataMember(Name = "monk")]
        public double Monk { get; set; }

        [DataMember(Name = "wizard")]
        public double Wizard { get; set; }

        [DataMember(Name = "witch-doctor")]
        public double WitchDoctor { get; set; }

        [DataMember(Name = "crusader")]
        public double Crusader { get; set; }
    }
}
