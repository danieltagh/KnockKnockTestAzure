using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewAzureTestWebApp.Controllers
{
    public class FibonacciController : ApiController
    {
        [HttpGet]
        public object Index(string n)
        {
            try
            {
                long numN = long.Parse(n);
                long absN = Math.Abs(numN);
                if (absN > 92)
                    throw new HttpResponseException(HttpStatusCode.BadRequest);
                else
                    return Fibo(absN) * (numN < 0  && absN % 2 == 0 ? -1 : 1);
            }
            catch (FormatException)
            {
                return new { message = "The request is invalid." };
            }
        }
        

        private long Fibo(long n)
        {
            long[] f = {0, 1, 1, 0 };
            for (int i = 2; i < n; i++)
            {
                f[3] = f[1] + f[2];
                f[1] = f[2];
                f[2] = f[3];
            }
            return f[Math.Min(n,3)];
        }
    }
}
