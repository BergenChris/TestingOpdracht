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
        public double minWeight = 80;
        public double maxWeight = 120;


        public DecisionBasedOnWeight() 
        {
        
        }
        public DecisionBasedOnWeight(Person person)
        {
            this.person = person;
        }

        public void Conditions(double min,double max) 
        {
            this.minWeight = min;
            this.maxWeight = max;
        }
    }
}
