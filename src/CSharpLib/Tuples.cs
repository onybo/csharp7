using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharpLib
{
    public class Tuples
    {
        public static (string message, HttpStatusCode statusCode) CallService1()
        {
            //do the call and get result and status code
            return ("hello", HttpStatusCode.OK);
        }

        public static void DeconstructTuple()
        {
            var (val, code) = CallService1();
            Console.WriteLine($"Value is {val}. Code is {code}");
        }

        public static void TupleParam((string code, HttpStatusCode mesg) val)
        {
            Console.WriteLine($"code: {val.Item1}.  Message: {val.Item2}");
        }

        public static void TupleParam((string val, string text) val)
        {
            Console.WriteLine(val.val + " : " + val.Item2);
        }

        public static void ObjectParam(object val)
        {
            Console.WriteLine(val.GetType());
        }

        public static void PrintStaticType<T>(T arg)
        {
            System.Console.WriteLine(typeof(T));
        }
        
        public static void TestObjectParam()
        {
            ObjectParam((Ape: 10, Tiger: 20));
        }

        public static void TestStaticType()
        {
            PrintStaticType((Ape: 10, Tiger: 20));
        }

        public static void TestReturnType()
        {
            var test = CallService1();
            PrintStaticType(test);
        }

    }
}
