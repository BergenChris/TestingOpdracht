using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace AmusementParkScale
{
    public class Person : IPerson
    {
        public double weight { get; set; }

        public string firstName { get; set; }

        public string Url { get; set; } = "https://dummyjson.com/users/";
      

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

        public double Weigh(string userId) 
        {
            using (var httpClient = new HttpClient())
            {
                var httpRespone = httpClient.GetAsync(Url+userId).GetAwaiter().GetResult();
                var response = httpRespone.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                this.weight = JsonConvert.DeserializeObject<Person>(response)!.weight;
                this.firstName = JsonConvert.DeserializeObject<Person>(response)!.firstName;
                return weight;
                
            }
            



       
        }

        
    }
}
