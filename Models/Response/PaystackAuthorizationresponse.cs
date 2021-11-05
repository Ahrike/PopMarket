using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Models.Response
{
    public class ValidateResponse
    {
        public string authorization_url { get; set; }
        public string access_code { get; set; }
        public string reference { get; set; }
    }

    public class PaystackResponse
    {
        public PaystackResponse()
        {
            data = new ValidateResponse();
        }

        public bool status { get; set; }
        public string message { get; set; }
        public ValidateResponse data { get; set; }
    }

}
