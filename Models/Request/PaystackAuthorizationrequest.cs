using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Models.Request
{
   
        public class CustomField
        {

            public string display_name { get; set; }

            public string variable_name { get; set; }

            public string value { get; set; }
        }

        public class PayStackRequest
        {
            public PayStackRequest()
            {
                metadata = new Metadata();
            }

            public string email { get; set; }
            public string reference { get; set; }
            public double amount { get; set; }
            public string callback_url { get; set; }
            public string subaccount { get; set; }
            public Metadata metadata { get; set; }
        }
        public class Metadata
    {
        private string mName = "";
        private string mId = "";

        public List<CustomField> custom_fields { get; set; }

        private void addToCustomFields(string displayName, string variableName, string value)
        {
            CustomField cf = new CustomField();
            cf.display_name = displayName;
            cf.variable_name = variableName;
            cf.value = value;
            if (custom_fields == null)
            {
                custom_fields = new List<CustomField>();
            }
            custom_fields.Add(cf);
        }

        public string merchant_name
        {
            get { return mName; }
            set
            {
                mName = value;
                addToCustomFields("Merchant Name", "merchant_name", value);
            }
        }

        public string merchant_id
        {
            get { return mId; }
            set
            {
                mId = value;
                addToCustomFields("Merchant ID", "merchant_id", value);
            }
        }

    }

    /*
     * I added CustomField incase the platform has more than one merchant and
     * want to differentiate each merchant transaction by unique value, maybe a merchant id
     * or merchant name
     * 
     */



}
