using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace WebApplication1.Pages
{
    public class HelloworldModel : PageModel
    {
        public StringValues name;
        public String result;
        

        public void OnGet()
        {
        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
            this.result = "Hey there " + name + "!";
        }

    }
}
