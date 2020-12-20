using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(true,message,data)
        {

        }
        public SuccessDataResult(T data):base(true,data)
        {

        }
    }
}
