using NewAzureTestWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewAzureTestWebApp.Controllers
{
    public class TriangleTypeController : ApiController
    {
        [HttpGet]
        public object Index(string a, string b, string c)
        {
            try
            {
                int[] sides = { int.Parse(a), int.Parse(b), int.Parse(c) };
                return new Triangle(sides).Type;
            }
            catch (FormatException)
            {
                return new { message = "The request is invalid." };
            }
            catch (ArgumentException ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
