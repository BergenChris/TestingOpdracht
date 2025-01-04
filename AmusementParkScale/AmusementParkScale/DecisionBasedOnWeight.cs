using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    public class DecisionBasedOnWeight
    {
        public Person person = new Person();
        public double minWeight;
        public double maxWeight;


        public DecisionBasedOnWeight() 
        {
        
        }
        public DecisionBasedOnWeight(Person person)
        {
            this.person = person;
        }
    }
}
