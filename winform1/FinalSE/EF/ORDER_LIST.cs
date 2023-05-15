//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalSE.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_LIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_LIST()
        {
            this.GOOD_DELIVERY = new HashSet<GOOD_DELIVERY>();
            this.INVOICEs = new HashSet<INVOICE>();
            this.ORDER_LIST_DETAILS = new HashSet<ORDER_LIST_DETAILS>();
        }
    
        public string OrderList_ID { get; set; }
        public string UserName_Agent { get; set; }
        public string UserName_Customer { get; set; }
        public Nullable<System.DateTime> Date_Created_OrderList { get; set; }
        public string Note { get; set; }
        public string Status_OrderList { get; set; }
    
        public virtual AGENT_ACCOUNT AGENT_ACCOUNT { get; set; }
        public virtual CUSTOMER_ACCOUNT CUSTOMER_ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOOD_DELIVERY> GOOD_DELIVERY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICE> INVOICEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_LIST_DETAILS> ORDER_LIST_DETAILS { get; set; }
    }
}