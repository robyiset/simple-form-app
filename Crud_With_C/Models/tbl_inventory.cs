

namespace Crud_With_C.Models
{
    using System;
    
    public class tbl_inventory
    {
        public int id_barang { get; set; }
        public int id_gudang { get; set; }
        public string nama_barang { get; set; }
        public int jumlah { get; set; }
        public DateTime create_date { get; set; }
        public string create_user { get; set; }
    }
}
