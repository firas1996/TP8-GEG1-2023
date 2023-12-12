using LibraryWebAppClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace LibraryWebAppClient.Controllers
{
    public class BookClientController : Controller
    {
        public async Task<IActionResult> GetAllBooks()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7204");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );
            HttpResponseMessage res = await client.GetAsync("api/books/get-all-books");
            if(res.IsSuccessStatusCode)
            {
                var books = await res.Content.ReadFromJsonAsync<IEnumerable<BookClient>>();
                return View(books);
            }
            else
            {
            return View();
            }
        }
    }
}
