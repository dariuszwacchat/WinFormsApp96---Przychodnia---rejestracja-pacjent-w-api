using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp96.Services
{
    public class RejestracjeService
    {
        private HttpClient _httpClient;
        public RejestracjeService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<Rejestracja>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("rejestracje");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <Rejestracja> rejestracje = JsonConvert.DeserializeObject<List<Rejestracja>> (stringData);
            return rejestracje;
        }

        public async Task<Rejestracja> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"rejestracje/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            Rejestracja rejestracja = JsonConvert.DeserializeObject <Rejestracja> (stringData);
            return rejestracja;
        }

        public async Task Create (Rejestracja rejestracja)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("rejestracje",
                new StringContent(JsonConvert.SerializeObject(rejestracja), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, Rejestracja rejestracja)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"rejestracje/{id}",
                new  StringContent(JsonConvert.SerializeObject (rejestracja), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"rejestracje/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
