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
    public class NuevoSnackStepsDefinition
    {
        private readonly ScenarioContext context;
        private string Name;
        private int Price;

        public NuevoSnackStepsDefinition(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"El nombre ""(.*)""")]
        public void GivenTheName(string name)
        {
            this.Name = name;
        }

        [Given(@"El precio ""(.*)""")]
        public void GivenTheSurname(int price)
        {
            this.Price = price;
        }


        [When(@"Creo un ""(.*)"" con esos valores")]
        public async Task WhenIPostThisRequestToTheOperation(string operation)
        {
            string requestBody = JsonConvert.SerializeObject(new { name = Name, price = Price});

            // set up Http Request Message
            // ATENCIÓN: Se deberá de modificar el puerto que está en la línea debajo
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://localhost:5001/{operation}")
            {
                Content = new StringContent(requestBody)
                {
                    Headers =
                        {
                          ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
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

        [Then(@"Veo el mensaje de éxito con código ""(.*)""")]
        public void ThenISeeTheSuccessMessageWitStatusCode(int statusCode)
        {
            Assert.Equal(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCode"));
        }
    }
}