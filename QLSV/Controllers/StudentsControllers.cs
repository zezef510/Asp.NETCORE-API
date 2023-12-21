using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QLSV.Controllers
{
    [Route("students")]
    public class StudentsControllers : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public StudentsControllers(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }


        [Route("")] // hoặc [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("ApiClient");

            var response = await client.GetAsync("api/students");
            if (response.IsSuccessStatusCode)
            {
                var students = await response.Content.ReadAsStringAsync();
                var studentViewModels = JsonConvert.DeserializeObject<List<StudentViewModel>>(students);

                return View(studentViewModels);
            }

            // Xử lý lỗi ở đây nếu cần

            return View(new List<StudentViewModel>());
        }
    }
}
