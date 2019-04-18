using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace imdbdtdd2
{
    public class imdbModel
    {
        public string title { get; set; }
        public int year { get; set; }
        public string rated { get; set; }
        public string released { get; set; }
        public string runtime { get; set; }
        public string genres { get; set; }
        public string director { get; set; }
        public string actors { get; set; }
        public string plot { get; set; }
        public string poster { get; set; }
        public string imdbrating { get; set; }
        public string imdbvotes { get; set; }
    }
}