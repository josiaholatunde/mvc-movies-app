using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController: Controller
    {
        //GET :/HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET :/HelloWorld/Welcome
        public string Welcome(string name, int numOfTimes)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}. This was called {numOfTimes}");
        }
    }
}