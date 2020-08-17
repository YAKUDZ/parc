using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcer.DbClasses
{
    class Series
    {
        public int id { get; set; }
        
        public string original_lang { get; set; }
        
        public string title { get; set; }

        public string about { get; set; }

        public string kinopoisk_rating { get; set; }

        public string imdb_rating { get; set; }

        public int age { get; set; }

        public int runtime { get; set; }

        public int release_date { get; set; }

        public int seasons { get; set; }

        public string image { get; set; }

    }
}
