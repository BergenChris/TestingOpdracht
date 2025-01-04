using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale.Tests
{
    public class IntegrationTest
    {

        private const double weight = 63.16;
        private const string MockoonUrl = "http://localhost:3001/users/1";

        [Test]
        public void WeighFromAPI() 
        {
            var person = new Person() { Url = MockoonUrl };

            var result = person.Weigh();

            Assert.That(result, Is.EqualTo(weight));
        }
    }
}
