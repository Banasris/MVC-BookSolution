using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class BookSearchViewModel
    {
        public string id { get; set; }
        public string booktype { get; set; }
        public string title { get; set; }
        public string isbn { get; set; }
        public string publisher { get; set; }
        public byte[] picture { get; set; }

        public string authorid { get; set; }
        public string name { get; set; }

        public virtual ICollection<author> authors { get; set; }

        public string authorbookid_ab { get; set; }
        public string authorid_ab { get; set; }
        public string bookid_ab { get; set; }

        public virtual ICollection<authorbook> authorbooks { get; set; }
        public virtual ICollection<review> reviews { get; set; }
    }
}