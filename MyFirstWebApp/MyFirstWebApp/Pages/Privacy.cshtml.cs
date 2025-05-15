using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyFirstWebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() //event handler method OnGet
        {
            string dateTime = DateTime.Now.ToShortDateString();
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
