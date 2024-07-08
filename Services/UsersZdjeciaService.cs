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
    public class UsersZdjeciaService
    {
        private HttpClient _httpClient;
        public UsersZdjeciaService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<ApplicationUserZdjecie>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("applicationUsersZdjecia");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <ApplicationUserZdjecie> usersZdjecia = JsonConvert.DeserializeObject<List<ApplicationUserZdjecie>> (stringData);
            return usersZdjecia;
        }

        public async Task<ApplicationUserZdjecie> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"applicationUsersZdjecia/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            ApplicationUserZdjecie userZdjecie = JsonConvert.DeserializeObject <ApplicationUserZdjecie> (stringData);
            return userZdjecie;
        }

        public async Task Create (ApplicationUserZdjecie userZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("applicationUsersZdjecia",
                new StringContent(JsonConvert.SerializeObject(userZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, ApplicationUserZdjecie userZdjecie)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"applicationUsersZdjecia/{id}",
                new  StringContent(JsonConvert.SerializeObject (userZdjecie), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"applicationUsersZdjecia/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
