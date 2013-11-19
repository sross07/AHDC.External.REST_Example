using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AHDC.External_RESTful
{
    public class SendOrder
    {
        public static void ToAHDC(DTO.LabOrder order, string username, string password)
        {
            // Written by Scott Ross
            // Cornell University 2013
            // Using REST Sharp, attach to our webserivces, send message
            // Serialization and Deserialization using REST Sharp

            //Instainaite the Rest Client using base url
            var client = new RestClient("https://secure.vet.cornell.edu/ahdc_external/");

            //Create the rest request uing the oepration (in this case, we are posting a lab order
            var request = new RestRequest("LabOrder/?format=xml", Method.POST);

            //Serialize Order
            RestSharp.Serializers.DotNetXmlSerializer serialize = new RestSharp.Serializers.DotNetXmlSerializer();
            String msg = serialize.Serialize(order).ToString();

            //Add msg to the parametertype of request body.  
            request.AddParameter(msg, ParameterType.RequestBody);
            request.AddHeader("username", username);
            request.AddHeader("password", password);       

           //Execute & access "content"
           var response = client.Execute(request);

           //Access the message in response
           var x = response.Content;          
        }
    }
}
