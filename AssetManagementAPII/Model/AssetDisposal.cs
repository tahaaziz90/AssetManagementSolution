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
    
    public partial class AssetDisposal
    {
        public int ID { get; set; }
        public int Asset_ID { get; set; }
        public int Disposal_ID { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual Disposal Disposal { get; set; }
    }
}