//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disposal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disposal()
        {
            this.AssetDisposals = new HashSet<AssetDisposal>();
            this.DisposalDetails = new HashSet<DisposalDetail>();
        }
    
        public int ID { get; set; }
        public string Disposal_Number { get; set; }
        public Nullable<System.DateTime> DateOfDisposal { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DisposedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetDisposal> AssetDisposals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisposalDetail> DisposalDetails { get; set; }
    }
}
