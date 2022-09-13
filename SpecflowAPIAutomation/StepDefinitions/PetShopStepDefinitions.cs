using System;
using TechTalk.SpecFlow;
using RestSharp;
using System.Net;

namespace SpecflowAPIAutomation.StepDefinitions
{
    [Binding]
    public class PetShopStepDefinitions
    {
        RestClient restClient;
        RestRequest request;
        RestResponse response;
        [Given(@"I have base url '([^']*)' and resource '([^']*)'")]
        public void GivenIHaveBaseUrlAndResourceWithPetid(string baseUrl, string resource)
        {
             restClient = new RestClient(baseUrl+resource);

        }

        [When(@"I do the Get Request")]
        public void WhenIDoTheGetRequest()
        {
            request = new RestRequest();
            response = restClient.Execute(request);
        }

        [Then(@"I should get a response as (.*)")]
        public void ThenIShouldGetAResponseAs(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Then(@"I should get the details of pet in json format")]
        public void ThenIShouldGetTheDetailsOfPetInJsonFormat()
        {

        }

        [Then(@"I should get a message as '([^']*)'")]
        public void ThenIShouldGetAMessageAs(string expectedMsg)
        {
            String actualResponse = response.Content;
            Assert.Contains(expectedMsg, actualResponse);
        }

        [Given(@"I need api_key '([^']*)' in the header")]
        public void GivenINeedApi_KeyInTheHeader(string apiKey)
        {
           // restClient.AddDefaultHeader("api_key", apiKey);
        }

        [When(@"I do the Delete Request")]
        public void WhenIDoTheDeleteRequest()
        {
            request = new RestRequest("",Method.Delete);
            response = restClient.Execute(request);

        }
    }
}
