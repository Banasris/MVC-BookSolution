using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookWeb.Models
{
    public class BookContext:DbContext
    {
        public BookContext()
            : base("name=MVCBookDBEntities")
        {
        }
        public DbSet<book> books { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<authorbook> authorbooks { get; set; }
        public DbSet<review> reviews { get; set; }
    }
}