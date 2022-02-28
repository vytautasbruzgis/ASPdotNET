using System;
using System.Collections.Generic;

namespace _20220224_DanskeCredit_API.Exceptions
{
    public class LoanRequestBadArgumentException : ArgumentException
    {
        public List<string> errors;
        public LoanRequestBadArgumentException() { }

        public LoanRequestBadArgumentException(List<string> errors) { 
            this.errors = errors;
        }
        public LoanRequestBadArgumentException(string message)
            : base(message) { }

        public LoanRequestBadArgumentException(string message, Exception inner)
            : base(message, inner) { }
    }
}
