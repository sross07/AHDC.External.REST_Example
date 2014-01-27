using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful
{
    class ExampleRest
    {
        static void Main(string[] args)
        {

            /* Written by Scott Ross
             * Cornell University 2013
             * All code herin is meant to provide examples on how 
             * to send orders to the AHDC RESTFUL webservices found here:
             * https://secure.vet.cornell.edu/ahdc_external_test/
             * https://secure.vet.cornell.edu/ahdc_external_test/xml/metadata?op=Result
             * This Codebase is not meant to be "Production code"
             * Libraries used within: nuget restsharp 104.3.3
             * */

            // This Creates a basic Order
            // This is done in classes than serialized to XML (or JSON...)
            var order = OrderCreation.MakeSimpleOrder();

            // This class uses RestSharp to send the order
            // Replace "username" and "password" with your real username and passowrd
            SendOrder.ToAHDC(order, "ahdc-tester@cornell.edu", "ahdc_test2010");
        }
    }
}
