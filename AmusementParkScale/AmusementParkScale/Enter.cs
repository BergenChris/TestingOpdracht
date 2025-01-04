using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    public class Enter
    {
        public int fails=0;
        public int maxFails = 3;
        public DecisionBasedOnWeight decision ;
        public Enter() { }
        public Enter(int fails,int maxFails,DecisionBasedOnWeight decision)
        {
            this.fails = fails;
            this.maxFails = maxFails;
            this.decision = decision;
        }

        public bool Work() 
        {
            
            if (fails < maxFails && decision.Work())
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

 
}
