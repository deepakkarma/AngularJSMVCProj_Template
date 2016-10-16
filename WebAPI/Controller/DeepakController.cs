using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controller
{
    public class DeepakController : ApiController
    {
        // GET: api/Deepak
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Deepak/5
        public string Get(int id)
        {
            return "DK Don";
        }

        // POST: api/Deepak
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Deepak/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Deepak/5
        public void Delete(int id)
        {
        }
    }
}
