using Inventory_API.Models;
using System.Linq;
using System.Web.Http;

namespace Inventory_API.Controllers
{
    public class userController : ApiController
    {
        private db_gudangEntities db = new db_gudangEntities();

        [HttpGet]
        public bool signin(string username, string password)
        {
            tbl_user tbl = db.tbl_user.Where(i => i.username == username && i.password == password).FirstOrDefault();
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
        public bool check_username(string username)
        {
            tbl_user tbl = db.tbl_user.Where(i => i.username == username).FirstOrDefault();
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
        public IHttpActionResult register(tbl_user tbl)
        {
            db.tbl_user.Add(tbl);
            db.SaveChanges();
            db.Dispose();
            return Ok();
        }
    }
}
