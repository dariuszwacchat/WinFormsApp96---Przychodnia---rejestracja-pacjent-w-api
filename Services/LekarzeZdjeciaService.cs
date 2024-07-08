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
    public class LekarzeZdjeciaService
    {
        private HttpClient _httpClient;
        public LekarzeZdjeciaService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<LekarzZdjecie>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("lekarzeZdjecia");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <LekarzZdjecie> lekarzeZdjecia = JsonConvert.DeserializeObject<List<LekarzZdjecie>> (stringData);
            return lekarzeZdjecia;
        }

        public async Task<LekarzZdjecie> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"lekarzeZdjecia/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            LekarzZdjecie lekarzZdjecie = JsonConvert.DeserializeObject <LekarzZdjecie> (stringData);
            return lekarzZdjecie;
        }

        public async Task Create (LekarzZdjecie lekarzZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("lekarzeZdjecia",
                new StringContent(JsonConvert.SerializeObject(lekarzZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, LekarzZdjecie lekarzZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"lekarzeZdjecia/{id}",
                new  StringContent(JsonConvert.SerializeObject (lekarzZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"lekarzeZdjecia/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
