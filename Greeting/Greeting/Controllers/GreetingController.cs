using Microsoft.AspNetCore.Mvc;

namespace Greeting.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        { // action='/Home/PostForm' can put in strign text form area

            //http://localhost:999/Hello

            string text = "<form method='post'>" +
                "<input name='name' type='text'/>" +
                "<select name='language'>" +
                "<option value='spanish'>spanish</option>" +
                "<option value='french'>french</option>" +
                "<option value='english'>english</option>" +
                "<option value='german'>german</option>" +
                "</select>" +  
                "<button>greet</button>" +
                "</form>";

            return Content(text, "text/html");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            var text = CreateMessage(name, language);
            return Content(text, "text/html");
        }
        public static string CreateMessage(string name, string language)
        {

            // string greeting = "";
            string greeting = null;
            switch (language)
            {
                case "spanish":
                    greeting = "Hola";
                    break;
                case "german":
                    greeting = "Hallo";
                    break;
                case "french":
                    greeting = "Bonjour";
                    break;
                default:
                    greeting = "Hello";
                    break;


                //        default:
                //            {
                //                throw new System.Exception("Hey this language isn't supported");
                //            }
                //    }
                //return Content(string.Format("{0}, {1}", greeting, firstName) , "text/html");

            }

            return greeting + " " + name;
        }

    }
}


namespace Bonjour.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var text = "<form method='post'>" +
                "<input name='name' type='text'/>" +
                "<select name='language'>" +
                "<option value='spanish'>spanish</option>" +
                "<option value='french'>french</option>" +
                "<option value='english'>english</option>" +
                "<option value='german'>german</option>" +
                "</select>" +
                "<button>greet</button>" +
                "</form>";
            return Content(text, "text/html");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            var text = CreateMessage(name, language);
            return Content(text, "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting = null;
            switch (language)
            {
                case "spanish":
                    greeting = "Hola";
                    break;
                case "german":
                    greeting = "Hallo";
                    break;
                case "french":
                    greeting = "Bonjour";
                    break;
                default:
                    greeting = "Hello";
                    break;
            }

            return greeting + " " + name;
        }
    }
}