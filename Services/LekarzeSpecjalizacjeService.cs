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
    public class LekarzeSpecjalizacjeService
    {
        private HttpClient _httpClient;
        public LekarzeSpecjalizacjeService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<LekarzSpecjalizacje>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("lekarzeSpecjalizacje");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <LekarzSpecjalizacje> lekarzeSpecjalizacje = JsonConvert.DeserializeObject<List<LekarzSpecjalizacje>> (stringData);
            return lekarzeSpecjalizacje;
        }

        public async Task<LekarzSpecjalizacje> Get (string lekarzId, string specjalizacjaId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"lekarzeSpecjalizacje/{lekarzId}&{specjalizacjaId}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            LekarzSpecjalizacje lekarzSpecjalizacje = JsonConvert.DeserializeObject <LekarzSpecjalizacje> (stringData);
            return lekarzSpecjalizacje;
        }

        public async Task Create (LekarzSpecjalizacje lekarzSpecjalizacje)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("lekarzeSpecjalizacje",
                new StringContent(JsonConvert.SerializeObject(lekarzSpecjalizacje), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        /*public async Task Edit (string id, LekarzSpecjalizacje lekarzSpecjalizacje)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"lekarzeSpecjalizacje/{id}",
                new  StringContent(JsonConvert.SerializeObject (lekarzSpecjalizacje), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }*/

        public async Task Delete (string lekarzId, string specjalizacjaId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"lekarzeSpecjalizacje/{lekarzId}&{specjalizacjaId}");
            response.EnsureSuccessStatusCode();
        }
    }
}
