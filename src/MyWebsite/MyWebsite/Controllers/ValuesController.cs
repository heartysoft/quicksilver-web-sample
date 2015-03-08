using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebsite.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private readonly ValueStorage _storage;

        public ValuesController(ValueStorage storage)
        {
            _storage = storage;
        }

        public ValuesController() : this(new ValueStorage())
        {
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _storage.GetValues();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
