//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYTHUVIEN
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTRA()
        {
            this.QLMUONTRAs = new HashSet<QLMUONTRA>();
        }
    
        public int MaPhieuTra { get; set; }
        public Nullable<int> MaPhieuMuon { get; set; }
        public Nullable<int> MaSach { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
    
        public virtual PHIEUMUON PHIEUMUON { get; set; }
        public virtual SACH SACH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLMUONTRA> QLMUONTRAs { get; set; }
    }
}
