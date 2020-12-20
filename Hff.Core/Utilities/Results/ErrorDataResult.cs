using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string message):base(false,message,data)
        {

        }
        public ErrorDataResult(T data):base(false,data)
        {

        }
    }
}
