using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Net.Http;
using AmusementParkScale;
using Newtonsoft.Json;
using System.Security.Policy;


namespace AmusementParkScaleFeatureTests.Test.StepDefenitions
{
    public class GetPersonFromAPISteps 
    {

        [TestFixture]
        public class GetPersonFromAPITests
        {
            private static HttpClient _httpClient;
            private HttpResponseMessage _response;


            [OneTimeSetUp]
            public static void OneTimeSetUp()
            {
                _httpClient = new HttpClient();
            }


            [OneTimeTearDown]
            public static void OneTimeTearDown()
            {
                _httpClient?.Dispose();
            }


            [SetUp]
            public void SetUp()
            {
                _response = null;  
            }

            [Test]
            public async Task CallTheApi()
            {

                _response = await _httpClient.GetAsync("https://dummyjson.com/users/1");

                Assert.That(_response.IsSuccessStatusCode, Is.True);
            }

            [Test]
            public async Task CallTheApiAndGetData()
            {

                _response = await _httpClient.GetAsync("https://dummyjson.com/users/1");
                var responseBody = _response.Content.ReadAsStringAsync().Result;
                Assert.That(responseBody.Contains("\"id\":1"), Is.True, "Response body does not contain the expected 'id'.");
            }


            [Test]
            public async Task TheApiCallCanCreateNewPerson()
            {
                var httpResponse = await _httpClient.GetAsync("https://dummyjson.com/users/1");
                var responseBody = await httpResponse.Content.ReadAsStringAsync();
                Person person = JsonConvert.DeserializeObject<Person>(responseBody)!;
                double weight = person?.weight ?? 0;
                Assert.That(person.weight, Is.EqualTo(weight), "Person weight does not match the expected value.");
            }  
        }
    }
}
