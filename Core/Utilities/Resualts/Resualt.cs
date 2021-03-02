using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class Resualt : IResualt
    {
        public Resualt(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Resualt(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
