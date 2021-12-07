using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crud_With_C.Services
{
    class ConnectionAPI
    {
        private HttpClient Client = new HttpClient{BaseAddress = new Uri("https://localhost:44394/")};
        public HttpContent GetContent(string url)
        {
            return Client.GetAsync("api/" + url).Result.EnsureSuccessStatusCode().Content;
        }

        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PostAsJsonAsync("api/" + url, model).Result.EnsureSuccessStatusCode();
        }

        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync("api/" + url, model).Result.EnsureSuccessStatusCode();
        }

        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync("api/" + url).Result.EnsureSuccessStatusCode();
        }
    }
}
