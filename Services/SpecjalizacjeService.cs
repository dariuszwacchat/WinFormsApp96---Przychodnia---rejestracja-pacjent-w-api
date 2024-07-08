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
    public class SpecjalizacjeService
    {
        private HttpClient _httpClient;
        public SpecjalizacjeService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<Specjalizacja>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("specjalizacje");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <Specjalizacja> specjalizacje = JsonConvert.DeserializeObject<List<Specjalizacja>> (stringData);
            return specjalizacje;
        }

        public async Task<Specjalizacja> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"specjalizacje/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            Specjalizacja specjalizacja = JsonConvert.DeserializeObject <Specjalizacja> (stringData);
            return specjalizacja;
        }

        public async Task Create (Specjalizacja specjalizacja)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("specjalizacje",
                new StringContent(JsonConvert.SerializeObject(specjalizacja), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, Specjalizacja specjalizacja)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"specjalizacje/{id}",
                new  StringContent(JsonConvert.SerializeObject (specjalizacja), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"specjalizacje/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
