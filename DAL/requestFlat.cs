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
    
    public partial class requestFlat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public requestFlat()
        {
            this.feedbacks = new HashSet<feedback>();
        }
    
        public int requestId { get; set; }
        public Nullable<int> flatId { get; set; }
        public Nullable<int> userRequestId { get; set; }
        public Nullable<System.DateTime> fromDate { get; set; }
        public Nullable<System.DateTime> untilDate { get; set; }
        public Nullable<System.DateTime> dateRequest { get; set; }
        public Nullable<bool> isOK { get; set; }
        public Nullable<int> numPoeple { get; set; }
        public Nullable<int> numChildren { get; set; }
        public string commands { get; set; }
        public Nullable<bool> isMeal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedback> feedbacks { get; set; }
        public virtual flat flat { get; set; }
        public virtual user user { get; set; }
    }
}