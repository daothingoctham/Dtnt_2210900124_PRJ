//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTNTHAM_2210900124_PRJ.Views.Shared
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            this.GiaodichTK = new HashSet<GiaodichTK>();
        }
    
        public int ThanhVienID { get; set; }
        public Nullable<int> KhachHangID { get; set; }
        public string CapDoThanhVien { get; set; }
        public Nullable<System.DateTime> NgayThamGia { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public Nullable<int> QuanTriID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaodichTK> GiaodichTK { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual QUANTRI QUANTRI { get; set; }
    }
}
