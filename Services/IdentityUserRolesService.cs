using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp96.Services
{
    public class IdentityUserRolesService
    {
        private HttpClient _httpClient;
        public IdentityUserRolesService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<IdentityUserRole<string>>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("identityUserRole");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <IdentityUserRole<string>> userRoles = JsonConvert.DeserializeObject<List<IdentityUserRole<string>>> (stringData);
            return userRoles;
        }

        public async Task<IdentityUserRole<string>> Get (string userId, string roleId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"identityUserRole/{userId}&{roleId}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            IdentityUserRole<string> userRole = JsonConvert.DeserializeObject <IdentityUserRole<string>> (stringData);
            return userRole;
        }

        public async Task Create (IdentityUserRole<string> userRole)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("identityUserRole",
                new StringContent(JsonConvert.SerializeObject(userRole), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        /*public async Task Edit (string id, IdentityUserRole<string> lekarz)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"identityUserRole/{id}",
                new  StringContent(JsonConvert.SerializeObject (lekarz), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }*/

        public async Task Delete (string userId, string roleId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"identityUserRole/{userId}&{roleId}");
            response.EnsureSuccessStatusCode();
        }
    }
}
