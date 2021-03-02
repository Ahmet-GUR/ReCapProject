using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public interface IDataResualt<T> : IResualt
    {
        T Data { get; }
    }
}
