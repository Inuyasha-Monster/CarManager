using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarManager.Api.Controllers
{
    public class BookController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(Book model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            return BadRequest(ModelState);
        }

    }
}
