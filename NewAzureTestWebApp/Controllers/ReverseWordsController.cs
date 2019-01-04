using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewAzureTestWebApp.Controllers
{
    public class ReverseWordsController : ApiController
    {
        [HttpGet]
        public object Index(string sentence)
        {
            return FlipStringWords(sentence);
        }
        private string FlipStringWords(string sentence)
        {
            if (sentence == null || sentence.Length == 0)
                return "";
            var split = sentence.Split(" ".ToCharArray());
            return split.Select(x => new string(x.Reverse().ToArray())).Aggregate((x, y) => $"{x} {y}");
        }
    }
}
