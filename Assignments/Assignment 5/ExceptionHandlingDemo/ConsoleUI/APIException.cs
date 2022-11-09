using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class APIException : Exception
    {

        public string ErrorMessage { get; set; }
        // create a default constructor
        public APIException()
        {

        }
        public APIException(string message)
        {
            this.ErrorMessage = message;
        }

    }

}
