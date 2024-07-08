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
    public class RejestratorPracyService
    {
        private HttpClient _httpClient;
        public RejestratorPracyService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<RejestratorPracy>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("rejestratorPracy");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <RejestratorPracy> rejestratorPrac = JsonConvert.DeserializeObject<List<RejestratorPracy>> (stringData);
            return rejestratorPrac;
        }

        public async Task<RejestratorPracy> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"rejestratorPracy/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            RejestratorPracy rejestratorPracy = JsonConvert.DeserializeObject <RejestratorPracy> (stringData);
            return rejestratorPracy;
        }

        public async Task Create (RejestratorPracy rejestratorPracy)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("rejestratorPracy",
                new StringContent(JsonConvert.SerializeObject(rejestratorPracy), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, RejestratorPracy rejestratorPracy)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"rejestratorPracy/{id}",
                new  StringContent(JsonConvert.SerializeObject (rejestratorPracy), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"rejestratorPracy/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
