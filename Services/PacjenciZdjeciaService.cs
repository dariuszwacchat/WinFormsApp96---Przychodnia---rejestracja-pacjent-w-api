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
    public class PacjenciZdjeciaService
    {
        private HttpClient _httpClient;
        public PacjenciZdjeciaService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<PacjentZdjecie>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("pacjenciZdjecia");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <PacjentZdjecie> pacjenciZdjecia = JsonConvert.DeserializeObject<List<PacjentZdjecie>> (stringData);
            return pacjenciZdjecia;
        }

        public async Task<PacjentZdjecie> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"pacjenciZdjecia/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            PacjentZdjecie pacjentZdjecie = JsonConvert.DeserializeObject <PacjentZdjecie> (stringData);
            return pacjentZdjecie;
        }

        public async Task Create (PacjentZdjecie pacjentZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("pacjenciZdjecia",
                new StringContent(JsonConvert.SerializeObject(pacjentZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, PacjentZdjecie pacjentZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"pacjenciZdjecia/{id}",
                new  StringContent(JsonConvert.SerializeObject (pacjentZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"pacjenciZdjecia/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
