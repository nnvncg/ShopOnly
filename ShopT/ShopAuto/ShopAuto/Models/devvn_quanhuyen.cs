//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopAuto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class devvn_quanhuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public devvn_quanhuyen()
        {
            this.devvn_xaphuongthitran = new HashSet<devvn_xaphuongthitran>();
        }
    
        public string maqh { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string matp { get; set; }
    
        public virtual devvn_tinhthanhpho devvn_tinhthanhpho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<devvn_xaphuongthitran> devvn_xaphuongthitran { get; set; }
    }
}
