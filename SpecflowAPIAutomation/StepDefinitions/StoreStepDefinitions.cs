using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace SpecflowAPIAutomation.StepDefinitions
{
    [Binding]
    public class StoreStepDefinitions
    {
        RestClient restClient;
        RestRequest request;
        RestResponse response;
        [Given(@"I have base url '([^']*)' and resource store '([^']*)'")]
        public void GivenIHaveBaseUrlAndResourceWithPetid(string baseUrl, string resource)
        {
            restClient = new RestClient(baseUrl + resource);

        }
        [When(@"I do the get request")]
        public void WhenIDoTheGetRequest()
        {
            request = new RestRequest();
            response = restClient.Execute(request);
        }

        [Then(@"I should get the response code as (.*)")]
        public void ThenIShouldGetTheResponseCodeAs(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }
    }
}
