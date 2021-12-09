using Inventory_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Inventory_API.Controllers
{
    public class inventoryController : ApiController
    {
        private db_gudangEntities db = new db_gudangEntities();

        [HttpGet]
        public List<tbl_inventory> getAllInventory()
        {
            return db.tbl_inventory.ToList();
        }

        [HttpGet]
        public tbl_inventory getInventory(string id)
        {
            return db.tbl_inventory.Where(x => x.id_barang == id).FirstOrDefault();
        }

        [HttpGet]
        public bool checkInventory(string id_check)
        {
            var tbl = db.tbl_inventory.Where(i => i.id_barang == id_check).FirstOrDefault();
            if (tbl != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public IHttpActionResult postInventory(tbl_inventory tbl)
        {
            db.tbl_inventory.Add(tbl);
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult putInventory(tbl_inventory tbl)
        {
            var db_tbl = db.tbl_inventory.Where(x => x.id_barang == tbl.id_barang).FirstOrDefault();
            if (db_tbl != null)
            {
                db_tbl.nama_barang = tbl.nama_barang;
                db_tbl.jumlah = tbl.jumlah;

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
        public IHttpActionResult deleteInventory(string id)
        {
            var db_tbl = db.tbl_inventory.Where(x => x.id_barang == id).FirstOrDefault();
            db.tbl_inventory.Remove(db_tbl);
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }
    }
}
