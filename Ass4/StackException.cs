using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass4
{
    class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }
}
