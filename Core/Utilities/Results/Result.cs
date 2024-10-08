using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getters are read only but can be set with constructor
        public Result(bool succses, string message) : this(succses)
        {
            Message = message;
        }
        public Result(bool succses)
        {
            Success = succses;
        }
        public bool Success { get; }

        public string Message { get; }



    }
}
