using Hosted.Shared;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hosted.Client.Pages
{
    public partial class DynamicForm
    {
        Form form;
        internal static readonly Dictionary<string, string> ElementValues = new Dictionary<string, string>();

        [Inject]
        protected HttpClient Http { get; set; }

        internal string strForm;
        internal string serverRequest;
        internal string serverResponse;

        protected override async Task OnInitializedAsync()
        {
            strForm = await Http.GetStringAsync("Form");

            form = JsonConvert.DeserializeObject<Form>(strForm, settings: new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
        }

        private async Task Submit()
        {
            serverRequest = JsonConvert.SerializeObject(ElementValues);
            var response = await Http.PostAsync("Form", new StringContent(serverRequest, encoding: Encoding.UTF8, mediaType: "application/json"));
            serverResponse = response.IsSuccessStatusCode ?
                await response.Content.ReadAsStringAsync() :
                response.StatusCode.ToString();
        }
    }
}
