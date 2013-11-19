using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class Order
    {
        public Order()
        {
            this.animals = new List<Animal>();
            //this.owner =new person();
            //this.animalOnsetSubmit = null;
            //this.herdIllnessDate = null;
        }

        //IsRequired = false
        public string additionalInstructions { get; set; }

        //IsRequired = false
        public DateTime? animalOnsetSubmit { get; set; }

        //IsRequired = true
        public List<Animal> animals { get; set; }

        //IsRequired= false
        public string diagnosis { get; set; }

        //IsRequired = false
        public person dvm { get; set; }

        //IsRequired = false
        public DateTime? herdIllnessDate { get; set; }

        //IsRequired = false
        public string herdSize { get; set; }

        //IsRequired = false
        public string history { get; set; }

        //IsRequired = false
        public string noAffected { get; set; }

        //IsRequired = false
        public string noDead { get; set; }

        //IsRequired = true
        public DateTime orderDate { get; set; }

        //IsRequired = false
        public person owner { get; set; }

        //IsRequired = false
        public string referenceNo { get; set; }
    }
}
