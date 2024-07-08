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
    public class LekarzeService
    {
        private HttpClient _httpClient;
        public LekarzeService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<Lekarz>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("lekarze");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <Lekarz> lekarze = JsonConvert.DeserializeObject<List<Lekarz>> (stringData);
            return lekarze;
        }

        public async Task<Lekarz> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"lekarze/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            Lekarz lekarz = JsonConvert.DeserializeObject <Lekarz> (stringData);
            return lekarz;
        }

        public async Task Create (Lekarz lekarz)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("lekarze",
                new StringContent(JsonConvert.SerializeObject(lekarz), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, Lekarz lekarz)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"lekarze/{id}",
                new  StringContent(JsonConvert.SerializeObject (lekarz), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"lekarze/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
