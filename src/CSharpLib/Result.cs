using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class Result
    {
        enum ResultType { OK, Fail }
        public bool OK { get; private set; }
        public string Message { get; private set; }

        public Result(bool ok, string message)
        {
            OK = ok;
            Message = message;
        }

        public static Result Success = new Result(true, "");
        public static Result Failure(string m) => new Result(false, m);
    }
}
