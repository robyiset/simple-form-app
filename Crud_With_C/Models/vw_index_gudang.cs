namespace Crud_With_C.Models
{
    using System;
    
    public class vw_index_gudang
    {
        public int id_gudang { get; set; }
        public string nama_gudang { get; set; }
        public string alamat { get; set; }
        public DateTime create_date { get; set; }
        public int? total_barang { get; set; }
    }
}
