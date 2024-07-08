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
    public class RolesService
    {
        private HttpClient _httpClient;
        public RolesService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<ApplicationRole>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("applicationRoles");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <ApplicationRole> role = JsonConvert.DeserializeObject<List<ApplicationRole>> (stringData);
            return role;
        }

        public async Task<ApplicationRole> Get (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"applicationRoles/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            ApplicationRole rola = JsonConvert.DeserializeObject <ApplicationRole> (stringData);
            return rola;
        }

        public async Task Create (ApplicationRole rola)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("applicationRoles",
                new StringContent(JsonConvert.SerializeObject(rola), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, ApplicationRole rola)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"applicationRoles/{id}",
                new  StringContent(JsonConvert.SerializeObject (rola), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"applicationRoles/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
