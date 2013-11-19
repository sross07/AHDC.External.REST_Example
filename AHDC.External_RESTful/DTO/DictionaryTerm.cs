using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class DictionaryTerm
    {
        //IsRequired = true
        public string code { get; set; }

        //IsRequired = true
        public string codingSystem { get; set; }

        //IsRequired = true
        public string description { get; set; }
    }
}
