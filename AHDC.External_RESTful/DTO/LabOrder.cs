using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
 
    public class LabOrder
    {
        public LabOrder()
        {
            this.Orders = new List<Order>();
        }       

        public List<Order> Orders { get; set; }
    }

}
