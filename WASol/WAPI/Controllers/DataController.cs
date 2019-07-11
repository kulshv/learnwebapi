using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WAPI.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet]
        [Route ("/api/data/alldata")]
        public IHttpActionResult get()
        {
            return Ok("Hi From Get");
        }
        // test
    }
}
