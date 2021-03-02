using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resualts
{
    public class SuccessResualt : Resualt
    {
        public SuccessResualt(string message) : base(true, message)
        {

        }

        public SuccessResualt() : base(true)
        {

        }
    }
}
