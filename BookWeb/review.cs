//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class review
    {
        public string reviewid { get; set; }
        public string reviewername { get; set; }
        public string bookid { get; set; }
        public Nullable<int> rating { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> dateodreview { get; set; }
    
        public virtual book book { get; set; }
    }
}