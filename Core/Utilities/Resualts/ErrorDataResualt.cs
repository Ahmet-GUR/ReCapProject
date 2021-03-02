using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class ErrorDataResualt<T> : DataResualt<T>
    {
        public ErrorDataResualt(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResualt(T data) : base(data, false)
        {

        }

        public ErrorDataResualt(string message) : base(default, false, message)
        {

        }

        public ErrorDataResualt() : base(default, false)
        {

        }
    }
}
