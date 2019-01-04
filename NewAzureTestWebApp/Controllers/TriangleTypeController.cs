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
                return GetTriangleType(int.Parse(a), int.Parse(b), int.Parse(c));
            }
            catch (FormatException)
            {
                return new { message = "The request is invalid." };
            }
        }
        private bool CanFormTriangle(params int[] sides)
        {
            if (sides.Length != 3 ||
                sides.Any(x => x <= 0) ||
                sides[0]+sides[1]<=sides[2] ||
                sides[0]+sides[2]<=sides[1] ||
                sides[1]+sides[2]<=sides[0])
                return false;
            return true;
        }
        private string GetTriangleType(params int[] sides)
        {
            if (!CanFormTriangle(sides))
            {
                return "Error";
            }
            if (sides[0] == sides[1] && sides[1] == sides[2])
                return "Equilateral";
            else if (sides[0] == sides[1] || sides[0] == sides[2] || sides[1] == sides[2])
                return "Isosceles";
            else
                return "Scalene";
        }
    }
}
