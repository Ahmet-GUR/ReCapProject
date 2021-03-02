using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class DataResualt<T> : Resualt, IDataResualt<T>
    {
        public DataResualt(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResualt(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
