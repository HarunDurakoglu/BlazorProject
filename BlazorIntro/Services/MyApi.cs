using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorIntro.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorIntro.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _http;

        public MyApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            return _http.GetJsonAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos?id=2");

        }
    }
}
