using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    public class Person
    {
        public double weight;

        public Person() 
        {
        
        }
        public Person(double weight)
        {
            this.weight = weight;
        }

        public Person(string weight)
        {
            this.weight = Convert.ToDouble(weight);
        }

        public double Weigh(Person person) 
        {
            
            
            return person.weight;
        }


    }
}
