using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class person
    {

        public person()
        {
            this.id = new DictionaryTerm();
        }

        //IsRequired = true
        public string address { get; set; }

        //IsRequired = false
        public string businessName { get; set; }

        //IsRequired = true
        public string city { get; set; }

        //IsRequired = false
        public string comments { get; set; }

        //IsRequired = false
        public string faxNo { get; set; }

        //IsRequired = true
        public string firstName { get; set; }

        //IsRequired = false
        public DictionaryTerm id { get; set; }

        //IsRequired = true
        public string lastName { get; set; }

        //IsRequired = false
        public string phoneNo { get; set; }

        //IsRequired = true
        public string state { get; set; }

        //IsRequired = true
        public string zipCode { get; set; }
    }
}
