using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Models
{
    public class PayStackConfig
    {
        public string BaseUrl { get; set; }

        public string PayKey { get; set; }

        public string subaccount { get; set; }


        /* Notes
     * subaccount codes can also be store in a db if the platform has many creators  
     * the subaccount code can be fetch with query or procedure with conditions that differentiate each creator(maybe a creator id )
     */
    }
}
