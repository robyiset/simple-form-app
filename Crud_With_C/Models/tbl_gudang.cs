

namespace Crud_With_C.Models
{
    using System;
    
    public class tbl_gudang
    {
        public int id_gudang { get; set; }
        public string nama_gudang { get; set; }
        public string alamat { get; set; }
        public DateTime create_date { get; set; }
        public string create_user { get; set; }
    }
}
