using System;

namespace Exception_Async_Await_Pj.ExceptionClasses
{
    internal class YoutubeAPI
    {
        public string ShowYoutubeException()
        {
            try
            {
                return "some low level youtube errors.";
            }
            catch (Exception ex)
            {
                // throw new CustomYoutubeException("Cannot fetch youtube", ex);
                return $"You cannot fetch video from youtube -> {ex.Message}.";
            }
        }
    }
}
