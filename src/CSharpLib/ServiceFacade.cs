using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharpLib
{
    public class ServiceFacade
    {
        public static (int value, HttpStatusCode statusCode) CallService1()
        {
            //do the call and get result and status code
            return (2, HttpStatusCode.OK);
        }

        public static void DeconstructTuple()
        {
            var (val, code) = CallService1();
            Console.WriteLine($"Value is {val}. Code is {code}");
        }

    }
}
