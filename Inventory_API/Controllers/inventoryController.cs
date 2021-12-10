using Inventory_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System;

namespace Inventory_API.Controllers
{
    public class inventoryController : ApiController
    {
        private db_gudangEntities db = new db_gudangEntities();

        [HttpGet]
        public List<tbl_inventory> getAllInventory(int id_gudang)
        {
            return db.tbl_inventory.Where(x => x.id_gudang == id_gudang).OrderByDescending(x => x.create_date).ToList();
        }

        [HttpGet]
        public List<tbl_inventory> searchInventory(string search, int id_gudang)
        {
            return db.tbl_inventory.Where(x => x.id_gudang == id_gudang && x.nama_barang.ToLower().Contains(search.ToLower())).OrderByDescending(x => x.create_date).ToList();
        }

        [HttpGet]
        public bool checkInventory(int id_check, int id_gudang)
        {
            var tbl = db.tbl_inventory.Where(i => i.id_gudang == id_gudang && i.id_barang == id_check).FirstOrDefault();
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
            db.tbl_inventory.Add( new tbl_inventory 
            {
                nama_barang = tbl.nama_barang,
                jumlah = tbl.jumlah,
                create_user = tbl.create_user,
                id_gudang = tbl.id_gudang,
                create_date = DateTime.Now
            });
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
        public IHttpActionResult deleteInventory(int id)
        {
            var db_tbl = db.tbl_inventory.Where(x => x.id_barang == id).FirstOrDefault();
            db.tbl_inventory.Remove(db_tbl);
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }
    }
}
