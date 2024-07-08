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
    public class AccountService
    {
        private HttpClient _httpClient;
        public AccountService ()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44391/api/account/") };
        }


        public async Task <HttpResponseMessage> Login (LoginViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("login",
                new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task Register (RegisterViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsync ("register",
                new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

    }
}
