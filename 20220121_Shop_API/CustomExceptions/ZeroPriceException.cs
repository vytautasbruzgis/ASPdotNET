using System;

namespace _20220121_Shop_API.CustomExceptions
{
    public class ZeroPriceException : ArgumentException
    {
        public ZeroPriceException(string Message) : base(Message)
        {

        }
    }
}
