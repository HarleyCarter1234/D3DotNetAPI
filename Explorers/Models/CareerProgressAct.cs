using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace D3DotNetAPI.Models
{
    [DataContract]
    public class CareerProgressAct
    {
        [DataMember(Name = "completed")]
        public bool Completed { get; set; }

        [DataMember(Name = "completedQuests")]
        public IEnumerable<CareerProgressCompletedQuset> CompletedQuests { get; set; }
    }
}
