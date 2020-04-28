using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLTV.Api
{

    [RoutePrefix("api/students")]
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("getall")]
        public IHttpActionResult GetAll()
        {
            return Json(new[] { "a", "b" });
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add(int id)
        {
            return Json("OK");
        }
    }
}
