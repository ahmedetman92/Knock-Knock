using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class MainController : ApiController
    {

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public int Fibonacci(long n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n-1; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            return c;
        }


        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string ReverseWords(string sentence)
        {
            return string.Join(" ",
            sentence.Split(' ')
           .Select(x => new String(x.Reverse().ToArray()))
           .ToArray());
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string Token()
        {
            return "d30ba4b1-a51b-44ae-a4b6-005fdebf6404";
        }


        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string TriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }  
        }
    }
}

