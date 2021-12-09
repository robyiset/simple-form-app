
namespace Crud_With_C.Models
{
    using System;
    using System.Collections.Generic;
    
    public class tbl_inventory
    {
        public string id_barang { get; set; }
        public string nama_barang { get; set; }
        public int jumlah { get; set; }
        public System.DateTime create_date { get; set; }
    }
}
