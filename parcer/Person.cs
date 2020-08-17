using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace parcer
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string name_en { get; set; }
        [DataMember]
        public string carrier { get; set; }
        [DataMember]
        public string height { get; set; }
        [DataMember]
        public string birthdate { get; set; }
        [DataMember]
        public string hometown { get; set; }
        [DataMember]
        public string[] genres { get; set; }
        [DataMember]
        public int movies_count { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public int[] all_projects { get; set; }
        [DataMember]
        public int[] best_series { get; set; }
    }
}
