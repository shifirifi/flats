//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class feedback
    {
        public int feedbackId { get; set; }
        public Nullable<int> flatUserId { get; set; }
        public Nullable<System.DateTime> dateComing { get; set; }
        public string text { get; set; }
    
        public virtual requestFlat requestFlat { get; set; }
    }
}
