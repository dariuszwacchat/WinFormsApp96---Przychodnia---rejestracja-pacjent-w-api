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
    public class PacjenciService
    {
        private HttpClient _httpClient;
        public PacjenciService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<Pacjent>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("pacjenci");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <Pacjent> pacjeci = JsonConvert.DeserializeObject<List<Pacjent>> (stringData);
            return pacjeci;
        }

        public async Task<Pacjent> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"pacjenci/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            Pacjent pacjet = JsonConvert.DeserializeObject <Pacjent> (stringData);
            return pacjet;
        }

        public async Task Create (Pacjent pacjet)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("pacjenci",
                new StringContent(JsonConvert.SerializeObject(pacjet), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, Pacjent pacjet)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"pacjenci/{id}",
                new  StringContent(JsonConvert.SerializeObject (pacjet), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"pacjenci/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
