using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public interface IResualt
    {
        bool Success { get; }
        string Message { get; }
    }
}
