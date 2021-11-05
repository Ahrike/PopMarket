using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Models.Utilities
{
    //public string HttpPostRestClientContentPayStack(string parameter, string url)
    //{
    //    string classMethodName = "Utilities|HttpPostRestClient";
    //    string apiKey = "";// ConfigurationManager.AppSettings["Paystack_apiKey"].ToString();

    //    try
    //    {
    //        var client = new RestClient(url);

    //        var request = new RestRequest(Method.POST);
    //        request.AddHeader("content-type", "application/json");
    //        request.AddHeader("authorization", "Bearer " + apiKey);
    //        request.AddParameter("application/json", parameter, ParameterType.RequestBody);



    //        var restResponse = client.Execute(request);

    //        if (string.IsNullOrEmpty(restResponse.Content))
    //        {
    //            //ErrHandler.WriteError(" Response content is empty, Parameter is  " + parameter + " URL is " + url + " Error is " + restResponse.ErrorException + " Error Message is " + restResponse.ErrorException);
    //            // return restResponse.ErrorMessage;
    //        }

    //        return restResponse.Content;
    //    }
    //    catch (Exception ex)
    //    {
    //        // ErrHandler.Log(classMethodName, url, ex.Message);
    //        return "Update customer transaction failed.";
    //    }
    //}

}
