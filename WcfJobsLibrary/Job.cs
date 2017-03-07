using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfJobsLibrary
{
    [DataContract]
    public class Job
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int MinLevel { get; set; }

        [DataMember]
        public int MaxLevel { get; set; }
    }
}
