using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Async_Await_Pj.ExceptionClasses
{
    internal class exceptions
    {
        public void ExceptionWithFinal()
        {
            try
            {
                Divide dv = new Divide();
                double reault = dv.Divide2Numbs(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("Sorry, You cannot divide by 0.");
            }
            catch (Exception ex)
            {
                throw new Exception("Sorry, sth wrong during opration.");
            }
        }
    }
}
