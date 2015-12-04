using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class AuthorModel
    {
        public string authorid { get; set; }
        public string name { get; set; }

        public virtual ICollection<authorbook> authorbooks { get; set; }
    }
}