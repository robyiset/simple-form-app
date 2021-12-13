using Inventory_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Inventory_API.Controllers
{
    public class gudangController : ApiController
    {
        private db_gudangEntities db = new db_gudangEntities();

        [HttpGet]
        public List<vw_index_gudang> getIndexGudang()
        {
            return db.vw_index_gudang.OrderByDescending(x => x.create_date).ToList();
        }

        [HttpGet]
        public List<vw_index_gudang> getSearchGudang(string search)
        {
            return db.vw_index_gudang.Where(x => x.nama_gudang.ToLower().Contains(search.ToLower())).OrderByDescending(x => x.create_date).ToList();
        }

        [HttpGet]
        public bool checkGudang(int id_check)
        {
            var tbl = db.tbl_gudang.Where(i => i.id_gudang == id_check).FirstOrDefault();
            if (tbl != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        public bool checkGudang(string name_check)
        {
            var tbl = db.tbl_gudang.Where(i => i.nama_gudang.ToLower() == name_check.ToLower()).FirstOrDefault();
            if (tbl != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        public string getNamaGudang(int id)
        {
            return db.tbl_gudang.Where(x => x.id_gudang == id).Select(x => x.nama_gudang).SingleOrDefault();
        }

        [HttpPost]
        public IHttpActionResult postGudang(tbl_gudang tbl)
        {
            db.tbl_gudang.Add(new tbl_gudang
            {
                nama_gudang = tbl.nama_gudang,
                alamat = tbl.alamat,
                create_user = tbl.create_user
            });
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult putGudang(tbl_gudang tbl)
        {
            var db_tbl = db.tbl_gudang.Where(x => x.id_gudang == tbl.id_gudang).FirstOrDefault();
            if (db_tbl != null)
            {
                db_tbl.nama_gudang = tbl.nama_gudang;
                db_tbl.alamat = tbl.alamat;
                db_tbl.create_user = tbl.create_user;

                db.SaveChanges();
                db.Dispose();

                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public IHttpActionResult deleteGudang(int id)
        {
            var db_tbl_gudang = db.tbl_gudang.Where(x => x.id_gudang == id).FirstOrDefault();
            db.tbl_gudang.Remove(db_tbl_gudang);
            db.SaveChanges();

            var db_tbl_inventory = db.tbl_inventory.Where(x => x.id_gudang == id).FirstOrDefault();
            db.tbl_inventory.Remove(db_tbl_inventory);
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }
    }
}
