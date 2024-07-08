using Domain;
using Domain.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks; 

namespace WinFormsApp96.Services
{
    public class UsersService
    {
        private HttpClient _httpClient;
        public UsersService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/") };
        }

        public async Task<List<ApplicationUser>> GetAll ()
        {
            HttpResponseMessage response = await _httpClient.GetAsync ("users");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            List <ApplicationUser> users = JsonConvert.DeserializeObject<List<ApplicationUser>> (stringData);
            return users;
        }

        public async Task<ApplicationUser> GetUserById (string id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"users/getUserById/{id}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            ApplicationUser user = JsonConvert.DeserializeObject <ApplicationUser> (stringData);
            return user;
        }

        public async Task<ApplicationUser> GetUserByEmail (string email)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"users/getUserByEmail/{email}");
            response.EnsureSuccessStatusCode();
            var stringData = await response.Content.ReadAsStringAsync ();
            ApplicationUser user = JsonConvert.DeserializeObject <ApplicationUser> (stringData);
            return user;
        }

        public async Task Create (CreateUserViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("users",
                new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Edit (string id, ApplicationUser user)
        {
            HttpResponseMessage response = await _httpClient.PutAsync ($"users/{id}",
                new  StringContent(JsonConvert.SerializeObject (user), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete (string id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync ($"users/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
