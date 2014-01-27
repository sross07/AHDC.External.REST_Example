using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.Response_DTO
{
    public class Ack
    {
        public String ErrorDetails { get; set; }
        public String Information { get; set; }
        public String MsgId { get; set; }

        // IF Status is AA, success
        // IF Status is AE, Bad
        public String Status { get; set; }
    }
}
