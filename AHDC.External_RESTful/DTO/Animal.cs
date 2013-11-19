using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHDC.External_RESTful.DTO
{
    public class Animal
    {

        public Animal()
        {
            //this.breed = new DictionaryTerm();
            //this.sex = new DictionaryTerm();
            //this.species = new DictionaryTerm();
            //this.specimens = new List<Specimen>();
        }

        //IsRequired = false
        public string age { get; set; }

        //IsRequired = true
        public string animalId { get; set; }

        //IsRequired = false
        public string animalName { get; set; }

        //IsRequired = false
        public DateTime? birthDate { get; set; }

        //IsRequired = false
        public DictionaryTerm breed { get; set; }

        //IsRequired = false
        public string leftEarTag { get; set; }

        //IsRequired = false
        public string nysRegistrationId { get; set; }

        //IsRequired = false
        public string rightEarTag { get; set; }

        //IsRequired = false
        public DictionaryTerm sex { get; set; }

        //IsRequired = false
        public DictionaryTerm species { get; set; }

        //IsRequired = false
        public List<Specimen> specimens { get; set; }
    }
}
