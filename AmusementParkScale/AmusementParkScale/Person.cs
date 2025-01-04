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

        public string Url { get; set; } = "https://dummyjson.com/users/1";
      

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

        public double Weigh() 
        {
            using (var httpClient = new HttpClient())
            {
                var httpRespone = httpClient.GetAsync(Url).GetAwaiter().GetResult();
                var response = httpRespone.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                Console.WriteLine(JsonConvert.DeserializeObject<Person>(response)!.weight);
                this.weight = JsonConvert.DeserializeObject<Person>(response)!.weight;
                return weight;
                
            }
            



       
        }

        
    }
}
