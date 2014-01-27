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
            var client = new RestClient("http://localhost:54490/");

            //Create the rest request uing the oepration (in this case, we are posting a lab order
            var request = new RestRequest("labOrder/?format=xml", Method.POST);           

            //Serialize Order
            RestSharp.Serializers.DotNetXmlSerializer serialize = new RestSharp.Serializers.DotNetXmlSerializer();
            String msg = serialize.Serialize(order).ToString();

            //Add msg to the parametertype of request body.  
            request.AddParameter("text/xml", msg, ParameterType.RequestBody);
            request.AddHeader("username", username);
            request.AddHeader("password", password);            

            //Execute & access "content"   
            //Access the message in response
            //The REsponse XML looks like:
            var res = client.ExecuteAsPost(request, "Post");
            res.ContentType = "application/xml";

            /*
            RestSharp.Deserializers.XmlDeserializer deserial = new RestSharp.Deserializers.XmlDeserializer();
            var response = deserial.Deserialize<Response_DTO.LabOrderResponse>(res);

            if (response.Ack.Status.Equals("AA"))
            {
                Console.WriteLine("Successfull Sending of Order!");
            }
            else
            {
                Console.WriteLine(response.Ack.ErrorDetails);
            }
             * */
        }
    }
}
