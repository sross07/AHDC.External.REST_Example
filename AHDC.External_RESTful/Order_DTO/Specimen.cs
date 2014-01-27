using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class Specimen
    {
        public Specimen()
        {
            this.tests = new List<Test>();
        }

        //IsRequired = false
        public DictionaryTerm sample { get; set; }

        //IsRequired = true
        public DateTime sampledDate { get; set; }

        //IsRequired = true
        public string specimenId { get; set; }

        //IsRequired = false
        public List<Test> tests { get; set; }
    }
}
