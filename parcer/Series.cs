using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace parcer
{
    [DataContract]
    public class Series
    {
        [DataMember]
        public string original_lang { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string about { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public float kinopoisk_rating { get; set; }
        [DataMember]
        public float imdb_rating { get; set; }
        [DataMember]
        public int[] country { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public int runtime { get; set; }
        [DataMember]
        public int year { get; set; }
        [DataMember]
        public int seasons { get; set; }
        [DataMember]
        public string[] genre { get; set; }
        [DataMember]
        public int releasedate { get; set; }
        [DataMember]
        public int[] recom { get; set; }
        [DataMember]
        public int[] directors { get; set; }
        [DataMember]
        public int[] actors { get; set; }
        [DataMember]
        public int[] producers { get; set; }
        [DataMember]
        public int[] writers { get; set; }
        [DataMember]
        public int[] operators { get; set; }
        [DataMember]
        public int[] artists { get; set; }
        [DataMember]
        public int[] editings { get; set; }
    }

}

