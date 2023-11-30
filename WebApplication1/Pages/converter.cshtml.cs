using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace WebApplication1.Pages
{
    public class ConverterModel : PageModel
    {
        public StringValues input;
        public String result;

        
        double rate;

        public int from;
        public int to;

        public void OnGet()
        {
        }
        public void OnPost()
        {
            
            this.input = Request.Form["input"];
            if (input != "")
            {
                Double newCurrency = Convert.ToDouble(input) * 1.13;
                this.result = "€" + newCurrency.ToString("F");
            }
            else
            {
                this.result = "Error: Input a Value";
            }
        }
    }

}
