using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class Test
    {
        public Test()
        {
            this.testCode = new DictionaryTerm();
        }

        //IsRequired = true
        public DictionaryTerm testCode { get; set; }
    }
}
