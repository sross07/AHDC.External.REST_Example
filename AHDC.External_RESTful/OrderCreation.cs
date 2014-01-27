using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHDC.External_RESTful.DTO;


namespace AHDC.External_RESTful
{
    public class OrderCreation
    {
        public static DTO.LabOrder MakeSimpleOrder()
        {

            // Written by Scott Ross
            // Cornell University 2013
            // This represents the simpliest order possible

            LabOrder labOrder = new DTO.LabOrder();
            Order order = new Order();

            //OrderDate is required.  
            order.orderDate = DateTime.Now;
            order.herdIllnessDate = DateTime.Now;
            order.animalOnsetSubmit = DateTime.Now;

            Animal animal = new Animal();
            animal.animalId = "Test Animal";
            animal.birthDate = DateTime.Now;
      
            order.animals.Add(animal);

            labOrder.Orders.Add(order);
            return labOrder;
        }
    }
}
