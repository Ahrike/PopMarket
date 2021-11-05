using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PopMarket.Web.Models;
using PopMarket.Web.Models.Request;
using PopMarket.Web.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Controllers
{
    public class PopController : Controller
    {
        private readonly IPayStackService _payStackService;

        private readonly IConfiguration _configuration;
        public PopController(IPayStackService payStackService, IConfiguration configuration)
        {
            _payStackService = payStackService;
            _configuration= configuration;
        }
       

        [HttpGet]
        public IActionResult Index(double amount)
        {
            var paydetails = new Checkout
            {
                Amount = amount
            };

            ViewBag.Paydetails = paydetails;
            return View();
        }

     

        [HttpPost]
        public async Task<IActionResult> Index(Checkout checkoutDetails)
        {
           
            var payStackConfig = new PayStackConfig();

            _configuration.Bind("PayStackConfig", payStackConfig);
            var request = new PayStackRequest
            {
                email = checkoutDetails?.Email,
                amount = checkoutDetails.Amount * 100,
                subaccount = payStackConfig.subaccount
            };
           
          var payservice = await _payStackService.GetPaymentUrl(request);

            return Redirect(payservice?.data.authorization_url);


           

            
        }


        /* Notes
     *call back url can also be included as part of the parameter so after making payment on paystack checkout, we route the  
     *customer back to the platform, call verify APi (https://api.paystack.co/transaction/verify/:reference) with the transaction unique reference
     *to verify the payment and let the customer download the content he/she paid for.
     */
    }
}