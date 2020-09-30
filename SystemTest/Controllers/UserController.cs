using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystemTest.Models;

namespace SystemTest.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        // GET: api/User
        [Route("getUserList")]
        public List<User> GetUserList()
        {
            return Data.getUserData();
        }

        // GET: api/User/5
        [Route("getSearchResults")]
        public List<User> Get(string fName, string lName)
        {

            List<User> res;
            if (fName != null && lName != null)
                res= Data.getUserData().Where(a => a.FName.ToLower().Contains(fName.ToLower()) || a.LName.ToLower().Contains(lName.ToLower())).ToList();
           else if (fName != null)
                res = Data.getUserData().Where(a => a.FName.ToLower().Contains(fName.ToLower())).ToList();
            else if(lName != null)
                res= Data.getUserData().Where(a => a.LName.ToLower().Contains(lName.ToLower())).ToList();
            else res = Data.getUserData().ToList();
            return res;
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
