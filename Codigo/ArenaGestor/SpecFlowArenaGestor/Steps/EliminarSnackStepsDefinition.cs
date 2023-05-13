using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowArenaGestor.Steps
{
    [Binding]
    public class EliminarSnackStepsDefinition
    {
        private readonly ScenarioContext context;
        private string Name;

        public EliminarSnackStepsDefinition(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"Un snack con el nombre ""(.*)""")]
        public void GivenTheName(string name)
        {
            this.Name = name;
        }

        [When(@"Elimino un ""(.*)"" con ese nombre")]
        public async Task WhenIPostThisRequestToTheOperation(string operation)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"https://localhost:5001/{operation}/{this.Name}") { };
            // create an http client
            var client = new HttpClient();
            // let's post
            var response = await client.SendAsync(request).ConfigureAwait(false);
            try
            {
                context.Set(response.StatusCode, "ResponseStatusCode");
            }
            finally
            {
                // move along, move along
            }
        }

        [Then(@"Veo el mensaje de éxito con el código ""(.*)""")]
        public void ThenISeeTheSuccessMessageWitStatusCode(int statusCode)
        {
            Assert.Equal(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCode"));
        }
    }
}
