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
    
    public partial class Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permission()
        {
            this.RolePermissions = new HashSet<RolePermission>();
        }
    
        public int ID { get; set; }
        public byte[] Permission_Name { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<System.DateTime> Deleted_On { get; set; }
        public bool IsDeleted { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
