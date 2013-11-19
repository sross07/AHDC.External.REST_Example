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

            // Create an order
            var order = OrderCreation.MakeSimpleOrder();

            // Send a rest Order
            SendOrder.ToAHDC(order, "username", "password");
        }
    }
}
