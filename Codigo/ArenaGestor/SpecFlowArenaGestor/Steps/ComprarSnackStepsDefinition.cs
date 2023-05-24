using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;
using System.Collections.Generic;
using System;

namespace SpecFlowArenaGestor.Steps
{
    [Binding]
    public class ComprarSnacksStepDefinition
    {
        private readonly ScenarioContext context;
        private string concertId;
        private int ticketQuantity;
        private string firstSnackName;
        private int firstSnackQuantity;
        private int firstSnackPrice;
        private string secondSnackName;
        private int secondSnackQuantity;
        private int secondSnackPrice;

        public ComprarSnacksStepDefinition(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"El id del concierto ""(.*)""")]
        public void GivenTheConcertId(string concertId)
        {
            this.concertId = concertId;
        }

        [Given(@"la cantidad de tickets ""(.*)""")]
        public void GivenTheTicketQuantity(int ticketQuantity)
        {
            this.ticketQuantity = ticketQuantity;
        }

        [Given(@"el nombre del primer snack ""(.*)""")]
        public void GivenTheFirstSnackName(string firstSnackName)
        {
            this.firstSnackName = firstSnackName;
        }

        [Given(@"la cantidad del primer snack ""(.*)""")]
        public void GivenTheFirstSnackQuantity(int firstSnackQuantity)
        {
            this.firstSnackQuantity = firstSnackQuantity;
        }

        [Given(@"el precio del primer snack ""(.*)""")]
        public void GivenTheFirstSnackPrice(int firstSnackPrice)
        {
            this.firstSnackPrice = firstSnackPrice;
        }

        [Given(@"el nombre del segundo snack ""(.*)""")]
        public void GivenTheSecondSnackName(string secondSnackName)
        {
            this.secondSnackName = secondSnackName;
        }

        [Given(@"la cantidad del segundo snack ""(.*)""")]
        public void GivenTheSecondSnackQuantity(int secondSnackQuantity)
        {
            this.secondSnackQuantity = secondSnackQuantity;
        }

        [Given(@"el precio del segundo snack ""(.*)""")]
        public void GivenTheSecondSnackPrice(int secondSnackPrice)
        {
            this.secondSnackPrice = secondSnackPrice;
        }

        [When(@"compro un ""(.*)"" con esos valores")]
        public async Task WhenIPostThisRequestToTheOperation(string operation)
        {
            string requestBody = JsonConvert.SerializeObject(
            new {
                concertId = concertId,
                amount = ticketQuantity,
                snackBuys = new List<Object>()
                {
                    new {
                        name = firstSnackName,
                        amount = firstSnackQuantity,
                        quantity = firstSnackPrice
                    },
                    new {
                        name = secondSnackName,
                        amount = secondSnackQuantity,
                        quantity = secondSnackPrice
                    }
                }
            });

            // set up Http Request Message
            // ATENCIÓN: Se deberá de modificar el puerto que está en la línea debajo
            var request = new HttpRequestMessage(HttpMethod.Post, $"https://localhost:5001/{operation}/Shopping")
            {
                Content = new StringContent(requestBody)
                {
                    Headers =
                        {
                          ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            request.Headers.Add("token", "7vFAIZlX1LUX0BxJ7BTn9eFWRUPGAQJOz6LtpZBVeemkCCZCk9mr0mteqstyKfXm");
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

        [Then(@"Veo como resultado el mensaje de éxito con código ""(.*)""")]
        public void ThenISeeTheSuccessMessageWitStatusCode(int statusCode)
        {
            Assert.Equal(statusCode, (int)context.Get<HttpStatusCode>("ResponseStatusCode"));
        }
    }
}