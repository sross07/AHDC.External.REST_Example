using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.Response_DTO
{
    public class LabOrderResponse
    {
        public LabOrderResponse()
        {
            this.Ack = new Ack();
        }

        public Ack Ack { get; set; }
    }
}
