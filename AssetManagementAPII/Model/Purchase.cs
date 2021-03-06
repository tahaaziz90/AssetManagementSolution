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
    
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.Assets = new HashSet<Asset>();
        }
    
        public int ID { get; set; }
        public int Currency_ID { get; set; }
        public int Supplier_ID { get; set; }
        public int PO_Number { get; set; }
        public string Invoice_Number { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Unit_Price { get; set; }
        public Nullable<double> Freight { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> Discount_Percent { get; set; }
        public Nullable<double> Total_Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
        public System.DateTime PO_Date { get; set; }
        public Nullable<System.DateTime> Ship_Date { get; set; }
        public Nullable<System.DateTime> Received_On { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<System.DateTime> Deleted_On { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
