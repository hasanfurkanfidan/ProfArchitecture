using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message,string process):base(false,message)
        {
            Process = process;
        }
        public ErrorResult():base(false)
        {

        }
        public string Process { get; set; }
    }
}
