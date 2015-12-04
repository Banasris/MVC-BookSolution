using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class AuthorBookModel
    {
        public string authorbookid { get; set; }
        public string bookid { get; set; }
        public string authorid { get; set; }

        public virtual author author { get; set; }
        public virtual book book { get; set; }
    }
}