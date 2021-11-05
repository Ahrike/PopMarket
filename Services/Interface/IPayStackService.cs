using PopMarket.Web.Models.Request;
using PopMarket.Web.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Services.Interface
{
    public interface IPayStackService
    {
        Task<PaystackResponse> GetPaymentUrl(PayStackRequest payStackRequest);
    }   
}
