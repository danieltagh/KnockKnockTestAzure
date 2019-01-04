using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewAzureTestWebApp.Controllers
{
    public class TokenController : ApiController
    {
        [HttpGet]
        public object Index()
        {
            return "9f33ef6f-9a39-40e5-9a7b-80cf78f5405e";
        }
    }
}
