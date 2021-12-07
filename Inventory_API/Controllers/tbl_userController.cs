using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Inventory_API.Models;

namespace Inventory_API.Controllers
{
    public class tbl_userController : ApiController
    {
        private db_gudangEntities db = new db_gudangEntities();

        // GET: api/tbl_user
        public IQueryable<tbl_user> Gettbl_user()
        {
            return db.tbl_user;
        }

        // GET: api/tbl_user/5
        [ResponseType(typeof(tbl_user))]
        public IHttpActionResult Gettbl_user(string id)
        {
            tbl_user tbl_user = db.tbl_user.Find(id);
            if (tbl_user == null)
            {
                return NotFound();
            }

            return Ok(tbl_user);
        }

        // PUT: api/tbl_user/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_user(string id, tbl_user tbl_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_user.username)
            {
                return BadRequest();
            }

            db.Entry(tbl_user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_userExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tbl_user
        [ResponseType(typeof(tbl_user))]
        public IHttpActionResult Posttbl_user(tbl_user tbl_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_user.Add(tbl_user);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_userExists(tbl_user.username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_user.username }, tbl_user);
        }

        // DELETE: api/tbl_user/5
        [ResponseType(typeof(tbl_user))]
        public IHttpActionResult Deletetbl_user(string id)
        {
            tbl_user tbl_user = db.tbl_user.Find(id);
            if (tbl_user == null)
            {
                return NotFound();
            }

            db.tbl_user.Remove(tbl_user);
            db.SaveChanges();

            return Ok(tbl_user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_userExists(string id)
        {
            return db.tbl_user.Count(e => e.username == id) > 0;
        }
    }
}