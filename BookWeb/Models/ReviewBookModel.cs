using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class ReviewBookModel
    {
        public string title { get; set; }
        public byte[] picture { get; set; }
        
        public string reviewid { get; set; }
        public string reviewername { get; set; }
        public string bookid { get; set; }
        public Nullable<int> rating { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> dateofreview { get; set; }

        public virtual book book { get; set; }
    }
}