using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class SuccessDataResualt<T> : DataResualt<T>
    {
        public SuccessDataResualt(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResualt(T data) : base(data, true)
        {

        }

        public SuccessDataResualt(string message) : base(default, true, message)
        {

        }

        public SuccessDataResualt() : base(default, true)
        {

        }
    }
}
