using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class AgeNotValid : ApplicationException
    {
        public AgeNotValid(string Message) : base(Message)
        {

        }
    }
    class ExceptionHandlingEg
    {
        static void Main()
        {
            try
            {
                int num = 10, div = 0;
                num = num / div;
                Console.WriteLine(num);
                if (div == 0)
                {
                    throw new DivideByZeroException();
                    //throw new Exception();
                }
               
            }
            catch
            {

            }
        }
    }
}
