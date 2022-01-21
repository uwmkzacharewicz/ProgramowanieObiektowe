using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PD220115
{
    public class NaszWyjatekException : System.Exception
    {
        public NaszWyjatekException(string message) 
            :base(message)
        {

        }

        public NaszWyjatekException(string message, Exception innerException)
            :base(message, innerException)
        {

        }

        public NaszWyjatekException(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {
              
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            throw new NaszWyjatekException("Wyjatek");          
        }
    }
}