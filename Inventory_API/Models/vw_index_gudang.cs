//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_index_gudang
    {
        public int id_gudang { get; set; }
        public string nama_gudang { get; set; }
        public string alamat { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<int> total_barang { get; set; }
    }
}
