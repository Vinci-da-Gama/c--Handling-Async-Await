using System;
using System.IO;

namespace Exception_Async_Await_Pj.ExceptionClasses
{
    internal class Exceptions
    {
        #region Exceptions
        public dynamic ExceptionDivideZero()
        {
            try
            {
                Divide dv = new Divide();
                double result = dv.Divide2Numbs(5, 0);
                return result;
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return "Sorry, sth wrong during opration.";
            }
        }

        public string ExceptionWithFinal()
        {
            // C: \Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C: \Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel\NotExistedFile.txt");
                var content = sr.ReadToEnd();
                return "Oops...";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Dispose();
                }
            }
        }

        public string ExceptionUsingBlock()
        {
            // C: \Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel
            try
            {
                /* the benefit of using block is, you donot need finlly anymore, because
                if the file doesnot exist, the streamreader will not be created, thus, donot
                need to dispose. */
                using (var srd = new StreamReader(@"C: \Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel\NotExistedFile.txt"))
                {
                    srd.ReadToEnd();
                    return "In using block.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExceptionYoutube()
        {
            try
            {
                var ytApi = new YoutubeAPI();
                var expStr = ytApi.ShowYoutubeException();
                return expStr;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

    }
}
