using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class ErrorResualt : Resualt
    {
        public ErrorResualt(string message) : base(false, message)
        {

        }

        public ErrorResualt() : base(false)
        {

        }
    }
}
