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
    
    public partial class TYPE_PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_PRODUCT()
        {
            this.MOBILE_PRODUCT = new HashSet<MOBILE_PRODUCT>();
        }
    
        public string TypeProduct_ID { get; set; }
        public string TypeProductName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOBILE_PRODUCT> MOBILE_PRODUCT { get; set; }
    }
}
