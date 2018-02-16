using System;

namespace Exception_Async_Await_Pj.ExceptionClasses
{
    internal class CustomYoutubeException: Exception
    {
        public CustomYoutubeException(string Msg, Exception innerException)
            : base(Msg, innerException)
        {
        }
    }
}
