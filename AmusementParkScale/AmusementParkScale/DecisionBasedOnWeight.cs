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
        public double minWeight = 60;
        public double maxWeight = 100;


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
        public bool Work() 
        {
            if (person.weight < minWeight) { return false; }
            else if (person.weight > maxWeight) { return false; }
            else { return true; }
        }
    }
}
